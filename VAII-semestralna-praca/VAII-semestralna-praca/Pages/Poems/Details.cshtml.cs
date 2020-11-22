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
    public class DetailsModel : PageModel
    {
        private readonly VAII_semestralna_praca.Data.PoemsContext _context;

        public DetailsModel(VAII_semestralna_praca.Data.PoemsContext context)
        {
            _context = context;
        }

        public Poem Poem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Poem = await _context.Poem.FirstOrDefaultAsync(m => m.ID == id);

            if (Poem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
