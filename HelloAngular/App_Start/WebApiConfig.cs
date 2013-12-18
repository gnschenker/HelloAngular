using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace HelloAngular.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "app/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }

            //config.Routes.MapHttpRoute("DefaultApiWithId", "app/api/{controller}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
            //config.Routes.MapHttpRoute("DefaultApiWithAction", "app/api/{controller}/{action}");
            //config.Routes.MapHttpRoute("DefaultApiGet", "app/api/{controller}", new { action = "Get" }, new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) });
            //config.Routes.MapHttpRoute("DefaultApiPost", "app/api/{controller}", new { action = "Post" }, new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) });
}