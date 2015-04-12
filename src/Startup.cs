using System;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.ConfigurationModel.Json;

using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;

//// To run this application following instructions:
//// 1). Setup proper connection string credentials in config.json
//// 2). In folder of this application at CMD line fire following command: "k ef migration apply"
//// 3). Add few records in the country table in DB
//// 4). Run application with: "k kestrel"
namespace aspnetefdemo
{
  public class Startup
  {
    public IConfiguration Configuration {get; set;}

    public Startup(IHostingEnvironment env)
    {
      this.Configuration = new Configuration().AddJsonFile("config.json").AddEnvironmentVariables();
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services
      .AddEntityFramework(Configuration)
      .AddSqlServer()
      .AddDbContext<DemoContext>();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc(routes =>
      {
        routes.MapRoute(
        name: "default",
        template: "{controller}/{action}/{id?}",
        defaults: new { controller = "Country", action = "Index" });
      });
    }
  }
}
