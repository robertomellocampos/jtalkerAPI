using API.Domain;
using API.Interface;
using Funq;
using MongoRepository;
using ServiceStack;

[assembly: WebActivator.PreApplicationStartMethod(typeof(API.App_Start.AppHost), "Start")]

//IMPORTANT: Add the line below to RouteConfig.RegisterRoutes(RouteCollection) in the Global.asax:
//routes.IgnoreRoute("api/{*pathInfo}"); 
//More info on how to integrate with MVC: https://github.com/ServiceStack/ServiceStack/wiki/Mvc-integration

/**
 * Entire ServiceStack Starter Template configured with a 'Hello' Web Service and a 'Todo' Rest Service.
 *
 * Auto-Generated Metadata API page at: /metadata
 * See other complete web service examples at: https://github.com/ServiceStack/ServiceStack.Examples
 */

namespace API.App_Start
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Hello Web Services", typeof(ActivityAPI).Assembly) { }

        public override void Configure(Container container)
        {
            container.Register(new MongoRepository<Activity>());
        }

        public static void Start()
        {
            new AppHost().Init();
        }
    }
}
