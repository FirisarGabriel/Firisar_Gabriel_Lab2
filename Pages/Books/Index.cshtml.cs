using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Firisar_Gabriel_Lab2.Data;
using Firisar_Gabriel_Lab2.Models;

namespace Firisar_Gabriel_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Firisar_Gabriel_Lab2.Data.Firisar_Gabriel_Lab2Context _context;

        public IndexModel(Firisar_Gabriel_Lab2.Data.Firisar_Gabriel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
