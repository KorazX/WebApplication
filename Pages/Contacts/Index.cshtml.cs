using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2;
using WebApplication2.Data;

namespace WebApplication2.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication2.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact
                .Include(c => c.Categories).ToListAsync();
            }
        }
    }
}
