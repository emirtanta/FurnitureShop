﻿using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
