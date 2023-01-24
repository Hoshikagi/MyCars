using MyCars.Entities;
using System.ComponentModel.DataAnnotations;

namespace MyCars.DTO
{
    public class GetAllCarsDto
    {
       
        public int Id { get; set;}         
        public int Year { get; set; }     
        public string Motor { get; set; }   
        public int Mileage { get; set; }      
        public string FuelType { get; set; }     
        public string Location { get; set; }     
        public string SteeringWheel { get; set; }     
        public bool IsCustomClearence { get; set; }             
        public int CarModelId { get; set; }
    }
}
