using MoviesTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MoviesTickets.Models
{
    public class Producer:IEntityBase
    {
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Name must be at least 3 char, not greater than 50")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }
        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
