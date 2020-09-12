using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using car_log.Data;
using car_log.Models;

namespace car_log.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly car_log.Data.CarLogContext _context;

        public IndexModel(car_log.Data.CarLogContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; }

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
