﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCentralOne.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Display (Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        [Required]
        [Display (Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Required]
        [Range(0,10)]
        [Display (Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
    }
}