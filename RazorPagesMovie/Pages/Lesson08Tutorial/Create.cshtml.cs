using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Lesson08Tutorial
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext _context;

        public CreateModel(RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lesson08TutorialMovies Lesson08TutorialMovies { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lesson08TutorialMovies.Add(Lesson08TutorialMovies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}