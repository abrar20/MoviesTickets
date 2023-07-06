using MoviesTickets.Data.Base;
using MoviesTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesTickets.Models
{
    public class Movie:IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")] // no need
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")] // no need
        public Producer Producer { get; set; }
    }
}
