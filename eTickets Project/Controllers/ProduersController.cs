using eTickets_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_Project.Controllers
{
    public class ProduersController : Controller
    { 

         private readonly AppDbContext _context;

           public ProduersController(AppDbContext context)
           {
               _context = context;
           }
    public async Task<IActionResult> Index()
        {
            var allproducers =await _context.Producers.ToListAsync();
            return View(allproducers);
        }
    }
}
