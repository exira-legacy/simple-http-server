namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.6")>]
[<assembly: AssemblyFileVersionAttribute("1.0.6")>]
[<assembly: AssemblyMetadataAttribute("githash","6ed4285069b81552ada07b67de1b60161fabc1d8")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.6"
