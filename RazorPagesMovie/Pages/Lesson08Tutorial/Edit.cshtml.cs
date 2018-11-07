using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Lesson08Tutorial
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext _context;

        public EditModel(RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lesson08TutorialMovies Lesson08TutorialMovies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lesson08TutorialMovies = await _context.Lesson08TutorialMovies.FirstOrDefaultAsync(m => m.ID == id);

            if (Lesson08TutorialMovies == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lesson08TutorialMovies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Lesson08TutorialMoviesExists(Lesson08TutorialMovies.ID))
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

        private bool Lesson08TutorialMoviesExists(int id)
        {
            return _context.Lesson08TutorialMovies.Any(e => e.ID == id);
        }
    }
}
