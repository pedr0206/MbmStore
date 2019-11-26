using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MbmStore.Infraestructure;


namespace MbmStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(Repository.Products
                 .Select(x => x.Category)
                 .Distinct()
                 .OrderBy(x => x));
        }
    }
}
