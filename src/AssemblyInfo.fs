namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.7")>]
[<assembly: AssemblyFileVersionAttribute("1.0.7")>]
[<assembly: AssemblyMetadataAttribute("githash","203d691bb0083d232c7efaeac25f04b24fcf09c3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.7"
