using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Lesson08TutorialMovies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
}
