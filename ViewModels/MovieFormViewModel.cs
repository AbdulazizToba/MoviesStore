using Movies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Field Required"), StringLength(250)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Field Required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Field Required"), Range(1,10)]
        public double Rate { get; set; }

        [Required(ErrorMessage = "Field Required"), StringLength(2500)]
        public string StoreLine { get; set; }

        [Display(Name = "Select poster..")]
        public byte[] Poster { get; set; }

        [Required(ErrorMessage = "Field Required"), Display(Name = "Ganre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
