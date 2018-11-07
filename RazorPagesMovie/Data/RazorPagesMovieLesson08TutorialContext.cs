using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class RazorPagesMovieLesson08TutorialContext : DbContext
    {
        public RazorPagesMovieLesson08TutorialContext (DbContextOptions<RazorPagesMovieLesson08TutorialContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Lesson08TutorialMovies> Lesson08TutorialMovies { get; set; }
    }
}
