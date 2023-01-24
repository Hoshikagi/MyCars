using System.ComponentModel.DataAnnotations;

namespace MyCars.DTO
{
    public class CarEditDto
    {
        [Key]
        public int Id { get; set; }    
        [Required]
        public int Year { get; set; }
        [Required]
        public string Motor { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string SteeringWheel { get; set; }
        [Required]
        public bool IsCustomClearence { get; set; }
        [Required]
        public int CarModelId { get; set; }

    }
}
