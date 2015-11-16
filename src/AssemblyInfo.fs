namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.2")>]
[<assembly: AssemblyFileVersionAttribute("1.0.2")>]
[<assembly: AssemblyMetadataAttribute("githash","bce4592bb5243c3c0db13caf77144b0305a22967")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.2"
