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
    public class DetailsModel : PageModel
    {
        private readonly car_log.Data.CarLogContext _context;

        public DetailsModel(car_log.Data.CarLogContext context)
        {
            _context = context;
        }

        public Record Record { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Record = await _context.Record.FirstOrDefaultAsync(m => m.Id == id);

            if (Record == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
