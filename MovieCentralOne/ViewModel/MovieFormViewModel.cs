using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieCentralOne.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieCentralOne.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
       
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(0, 10)]
        [Display(Name = "Number in Stock")]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";

            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}