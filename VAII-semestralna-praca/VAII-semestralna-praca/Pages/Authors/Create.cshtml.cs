using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VAII_semestralna_praca.Data;
using VAII_semestralna_praca.Models;

namespace VAII_semestralna_praca.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly VAII_semestralna_praca.Data.PoemsContext _context;

        public CreateModel(VAII_semestralna_praca.Data.PoemsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Author Author { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
