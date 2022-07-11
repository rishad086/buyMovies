using System.ComponentModel.DataAnnotations;

namespace buyMovies.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should be in between 3 to 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "BioGraphy is required")]
       

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
