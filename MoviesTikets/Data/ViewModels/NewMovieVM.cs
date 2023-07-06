using MoviesTickets.Data.Base;
using MoviesTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Display(Name = "Movie Image")]
        [Required(ErrorMessage = "Image is Required")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is Required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is Required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is Required")]
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        //public List<Actor_Movie> Actors_Movies { get; set; }
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]

        public int ProducerId { get; set; }

    }
}
