using HelloAngular.App_Start;
using System;
using System.Web.Http;

namespace HelloAngular
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}