using buyMovies.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace buyMovies.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]

        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]


        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]


        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
