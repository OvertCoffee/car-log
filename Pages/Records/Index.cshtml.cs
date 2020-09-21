using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using car_log.Data;
using car_log.Models;

namespace car_log.Pages.Records
{
    public class IndexModel : PageModel
    {
        private readonly car_log.Data.CarLogContext _context;

        public IndexModel(car_log.Data.CarLogContext context)
        {
            _context = context;
        }

        public IList<Record> Records { get;set; }

        public async Task OnGetAsync()
        {
            Records = await _context.Record.OrderByDescending(r => r.Time).ToListAsync();
        }
    }
}
