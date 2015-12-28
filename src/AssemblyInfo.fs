namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.4")>]
[<assembly: AssemblyFileVersionAttribute("1.0.4")>]
[<assembly: AssemblyMetadataAttribute("githash","2eec7c686b94fd7dc37d6317bbba8e8a5d605e63")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.4"
