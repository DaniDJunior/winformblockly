using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.StaticFiles.ContentTypes;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace Blockly
{
    public class CustomContentTypeProvider : FileExtensionContentTypeProvider
    {
        public CustomContentTypeProvider()
        {
            Mappings.Add(".json", "application/json");
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                DefaultFilesOptions = { DefaultFileNames = { "index.html" } },
                FileSystem = new PhysicalFileSystem("Assets"),
                StaticFileOptions = { ContentTypeProvider = new CustomContentTypeProvider() }
            };

            try
            {

                HttpConfiguration config = new HttpConfiguration();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

                app.UseWebApi(config);

                app.Map("/signalr", map =>
                {
                    map.UseCors(CorsOptions.AllowAll);

                    var hubConfiguration = new HubConfiguration
                    {
                        EnableJSONP = true,
                        EnableDetailedErrors = true,
                        EnableJavaScriptProxies = true
                    };

                    map.RunSignalR(hubConfiguration);
                })
                .UseFileServer(options);
                app.UseStaticFiles();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
