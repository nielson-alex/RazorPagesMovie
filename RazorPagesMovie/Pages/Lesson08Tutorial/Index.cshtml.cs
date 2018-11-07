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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext _context;

        public IndexModel(RazorPagesMovie.Models.RazorPagesMovieLesson08TutorialContext context)
        {
            _context = context;
        }

        public IList<Lesson08TutorialMovies> Lesson08TutorialMovies { get;set; }

        public async Task OnGetAsync()
        {
            Lesson08TutorialMovies = await _context.Lesson08TutorialMovies.ToListAsync();
        }
    }
}
