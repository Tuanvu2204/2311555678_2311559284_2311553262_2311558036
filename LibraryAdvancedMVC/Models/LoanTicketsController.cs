using LibraryAdvancedMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAdvancedMVC.Controllers
{
    public class LoanTicketsController : Controller
    {
        private readonly LibraryAdvancedDbContext _context;

        public LoanTicketsController(LibraryAdvancedDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tickets = await _context.LoanTickets
                .Include(x => x.LoanDetails)
                .ToListAsync();

            return View(tickets);
        }
    }
}