using System.Web.Mvc;

namespace Checkers.WebUI.Areas.Templete
{
    public class TempleteAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Templete";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Templete_default",
                "Templete/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
