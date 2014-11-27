namespace SimpleHttpServer
{
    using System;
    using System.Globalization;
    using Microsoft.Owin.FileSystems;
    using Microsoft.Owin.Hosting;
    using Microsoft.Owin.StaticFiles;
    using Microsoft.Owin.StaticFiles.ContentTypes;
    using Owin;

    class Program
    {
        static void Main(string[] args)
        {
            var rootPath = args.Length > 1 ? args[1] : ".";
            var rootPort = args.Length > 0 ? args[0] : new Random().Next(2000, 65000).ToString(CultureInfo.InvariantCulture);

            var url = string.Format("http://localhost:{0}", rootPort);

            var fileSystem = new PhysicalFileSystem(rootPath);

            var contentTypeProvider = new FileExtensionContentTypeProvider();
            contentTypeProvider.Mappings.Add(".json", "application/json");

            var options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                FileSystem = fileSystem
            };

            options.StaticFileOptions.ContentTypeProvider = contentTypeProvider;

            WebApp.Start(url, builder => builder.UseFileServer(options));
            Console.WriteLine("Listening at " + url);
            Console.ReadLine();
        }
    }
}