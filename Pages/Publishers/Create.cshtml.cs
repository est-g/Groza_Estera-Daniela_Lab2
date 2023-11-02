﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Groza_Estera_Daniela_Lab2.Data;
using Groza_Estera_Daniela_Lab2.Models;

namespace Groza_Estera_Daniela_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Groza_Estera_Daniela_Lab2.Data.Groza_Estera_Daniela_Lab2Context _context;

        public CreateModel(Groza_Estera_Daniela_Lab2.Data.Groza_Estera_Daniela_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}