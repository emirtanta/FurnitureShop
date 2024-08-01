using FurnitureShop.Entities;
using FurnitureShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TeamController : Controller
    {
        private readonly FurnitureContext _context;

        public TeamController(FurnitureContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            var result =  _context.Teams.ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Add(team);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(team);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTeam(Team team)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Teams.Update(team);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Lütfen tekrar deneyiniz!");
                }
            }
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
