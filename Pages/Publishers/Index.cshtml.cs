using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Firisar_Gabriel_Lab2.Data;
using Firisar_Gabriel_Lab2.Models;

namespace Firisar_Gabriel_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Firisar_Gabriel_Lab2.Data.Firisar_Gabriel_Lab2Context _context;

        public IndexModel(Firisar_Gabriel_Lab2.Data.Firisar_Gabriel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }

        /*{
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }*/
    }
}
