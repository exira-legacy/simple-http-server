namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.3")>]
[<assembly: AssemblyFileVersionAttribute("1.0.3")>]
[<assembly: AssemblyMetadataAttribute("githash","bc40fa7748fe3dfa3dcc743d74d86901a38f8a41")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.3"
