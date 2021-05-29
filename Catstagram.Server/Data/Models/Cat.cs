using System.ComponentModel.DataAnnotations;

namespace Catstagram.Server.Data.Models
{
    using static Validation.Cat;
    public class Cat
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(Validation.Cat.MaxDescriptionLength)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
