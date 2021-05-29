using Catstagram.Server.Data;
using System.ComponentModel.DataAnnotations;

namespace Catstagram.Server.Models.Cats
{
    using static Validation.Cat;
    public class CreateCatRequestModel
    {
        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
