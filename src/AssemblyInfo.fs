namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0.0")>]
[<assembly: AssemblyMetadataAttribute("githash","1e5734cfda4782cb6e532d54e754f9f9fca5b97f")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.0"
