using System.ComponentModel.DataAnnotations;

namespace ProjectUpdate.Models
{
    public class MovieDto
    {
        [Required]
        public string Title { get; set; }

        //[Required]
        public IFormFile? ImageURL { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Producer { get; set; }
        [Required]
        public string Actor { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public float Price { get; set; }

    }
}
