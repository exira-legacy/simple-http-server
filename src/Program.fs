open System
open Exira.ErrorHandling
open Nessos.Argu

open Owin
open Microsoft.Owin.FileSystems
open Microsoft.Owin.Hosting
open Microsoft.Owin.StaticFiles
open Microsoft.Owin.StaticFiles.ContentTypes

type Errors =
    | ParsingArgumentsFailed of exn
    | StartingServerFailed of exn

let format errors =
    let formatError error =
        match error with
        | ParsingArgumentsFailed ex -> sprintf "Could not parse arguments: %s" ex.Message
        | StartingServerFailed ex -> sprintf "Could not start webserver: %s" ex.Message

    errors
    |> List.map formatError

type Arguments =
    | Port of int
    | Path of string
with
    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | Port _ -> "specify a port to listen on."
            | Path _ -> "specify a root path to serve."

let parser = ArgumentParser.Create<Arguments>()

let parseArguments argv =
    try
        parser.Parse argv |> succeed
    with
    | ex -> fail [ParsingArgumentsFailed ex]

let determineOptions (args: ParseResults<Arguments>) =
    let randomPort = Random().Next(2000, 65000)
    let rootPort = args.GetResult(<@ Port @>, defaultValue = randomPort)
    let rootPath = args.GetResult(<@ Path @>, defaultValue = ".")
    succeed (rootPort, rootPath)

let startWebserver (port, path) =
    let url = sprintf "http://localhost:%i" port
    let fileSystem = PhysicalFileSystem(path)

    let contentTypeProvider = FileExtensionContentTypeProvider()
    contentTypeProvider.Mappings.Add(".json", "application/json")

    let options =
        FileServerOptions(
            EnableDirectoryBrowsing = true,
            EnableDefaultFiles = true,
            FileSystem = fileSystem
        )

    options.StaticFileOptions.ContentTypeProvider <- contentTypeProvider;

    try
        WebApp.Start(url, fun builder -> builder.UseFileServer(options) |> ignore) |> ignore
        succeed url
    with
    | ex -> fail [StartingServerFailed ex]

[<EntryPoint>]
let main argv =
    let server =
        argv
        |> parseArguments
        |> bind determineOptions
        |> bind startWebserver

    match server with
    | Success result ->
        printfn "Listening at %s" result
        Console.ReadLine() |> ignore
        0

    | Failure errors ->
        let errorMessages = errors |> format
        printfn "%s" <| String.concat Environment.NewLine errorMessages
        -1
