using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Controllers
{
    public class ContactController : Controller
    {
        private readonly FurnitureContext _context;

        public ContactController(FurnitureContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();

            if (contactInfo != null)
            {
                ViewBag.Address = contactInfo.Description;
                ViewBag.Email = contactInfo.Email;
                ViewBag.Phone = contactInfo.Phone;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserMessage userMessage)
        {
            if (ModelState.IsValid)
            {
                _context.UserMessages.Add(userMessage);

                await _context.SaveChangesAsync();

                ViewBag.Message = "Mesajınız başarıyla gönderildi";

                //form gönderildikten sonra sayfayı yeniden yüklemeden gösterim için redirect kullanaıldı
                return Json(new { success = true });
            }

            var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();

            if (contactInfo != null)
            {
                ViewBag.Address = contactInfo.Description;
                ViewBag.Email = contactInfo.Email;
                ViewBag.Phone = contactInfo.Phone;
            }

            return View(userMessage);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(UserMessage userMessage)
        {
            if (ModelState.IsValid)
            {
                _context.UserMessages.Add(userMessage);

                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
    }
}
