namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("simple-http-server")>]
[<assembly: AssemblyProductAttribute("Exira.SimpleHttpServer")>]
[<assembly: AssemblyDescriptionAttribute("Exira.SimpleHttpServer is a simple HTTP server to serve static files")>]
[<assembly: AssemblyVersionAttribute("1.0.5")>]
[<assembly: AssemblyFileVersionAttribute("1.0.5")>]
[<assembly: AssemblyMetadataAttribute("githash","226d1dde7a52512f7507dcf6636fcee70e43d9cf")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.5"
