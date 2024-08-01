using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.ViewComponents
{
    public class _AdminSideBarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View(); 
        }
    }
}
