using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Lesson08Tutorial
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext _context;

        public DeleteModel(RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lesson08TutorialMovies = await _context.Lesson08TutorialMovies.FindAsync(id);

            if (Lesson08TutorialMovies != null)
            {
                _context.Lesson08TutorialMovies.Remove(Lesson08TutorialMovies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
