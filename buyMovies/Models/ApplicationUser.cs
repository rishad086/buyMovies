using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace buyMovies.Models
{
    public class ApplicationUser:IdentityUser
    {
          
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    
}
}
