namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0.0")>]
[<assembly: AssemblyMetadataAttribute("githash","0c4445b9ff46e2c033fde9c280b3ad8d14ddcf16")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.0"
