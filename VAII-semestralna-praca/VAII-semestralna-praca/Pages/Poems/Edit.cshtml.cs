using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VAII_semestralna_praca.Data;
using VAII_semestralna_praca.Models;

namespace VAII_semestralna_praca.Pages.Poems
{
    public class EditModel : PageModel
    {
        private readonly VAII_semestralna_praca.Data.PoemsContext _context;

        public EditModel(VAII_semestralna_praca.Data.PoemsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Poem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PoemExists(Poem.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PoemExists(int id)
        {
            return _context.Poem.Any(e => e.ID == id);
        }
    }
}
