using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VAII_semestralna_praca.Data;
using VAII_semestralna_praca.Models;

namespace VAII_semestralna_praca.Pages.Poems
{
    public class IndexModel : PageModel
    {
        private readonly VAII_semestralna_praca.Data.PoemsContext _context;

        public IndexModel(VAII_semestralna_praca.Data.PoemsContext context)
        {
            _context = context;
        }

        public IList<Poem> Poem { get;set; }

        public async Task OnGetAsync()
        {
            Poem = await _context.Poem.ToListAsync();
        }
    }
}
