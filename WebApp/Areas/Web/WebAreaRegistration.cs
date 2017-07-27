using System.Web.Mvc;

namespace WebApp.Areas.Web
{
    public class WebAreaRegistration : AreaRegistration 
    {
        public override string AreaName
        {
            get
            {
                return "Web";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Web_default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "WebApp.Areas.Web.Controllers" }
            );
        }
    }
}