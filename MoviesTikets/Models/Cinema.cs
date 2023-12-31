﻿using MoviesTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MoviesTickets.Models
{
    public class Cinema:IEntityBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
