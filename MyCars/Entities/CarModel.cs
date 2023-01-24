using System.ComponentModel.DataAnnotations;

namespace MyCars.Entities
{
    public class CarModel
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
