using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VAII_semestralna_praca.Data;
using VAII_semestralna_praca.Models;

namespace VAII_semestralna_praca.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly VAII_semestralna_praca.Data.PoemsContext _context;

        public IndexModel(VAII_semestralna_praca.Data.PoemsContext context)
        {
            _context = context;
        }

        public IList<Models.Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
