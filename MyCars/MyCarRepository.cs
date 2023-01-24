using MyCars.Entities;
using MyCars.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;
using MyCars.DTO;

namespace MyCars
{
    public class MyCarRepository : IMyCarRepository
    {
        private readonly AppDbContext _appDbContext;
        public MyCarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(CreateCarDto carDto)
        {
            if (carDto.Year < 1992)
            {
                throw new Exception("car is very old");
            }

            Car car = new Car()
            {
                Year = carDto.Year,              
                Motor = carDto.Motor,
                Mileage = carDto.Mileage,
                FuelType = carDto.FuelType,
                Location = carDto.Location,
                CarModelId = carDto.CarModelId,
                IsCustomClearence = carDto.IsCustomClearence,
                SteeringWheel = carDto.SteeringWheel,
            };
            
            _appDbContext.Cars.Add(car);
            _appDbContext.SaveChanges();
        }

        public CarEditDto Edit(CarEditDto editedCarDto)
        {
            Car car = new Car
            {               
                Id = editedCarDto.Id,
                FuelType = editedCarDto.FuelType,
                Year = editedCarDto.Year,
                Motor = editedCarDto.Motor,
                Mileage = editedCarDto.Mileage,
                Location = editedCarDto.Location,
                CarModelId = editedCarDto.CarModelId,
                SteeringWheel = editedCarDto.SteeringWheel,
                IsCustomClearence = editedCarDto.IsCustomClearence
            };
            
            _appDbContext.Cars.Update(car);
            _appDbContext.SaveChanges();
            return editedCarDto;
        }

        public List<GetAllCarsDto> GetAllCars()
        {
            List<Car> cars = _appDbContext.Cars.ToList();
            List<GetAllCarsDto> carsDto = cars.Select(x => new GetAllCarsDto()
            {                
                Year = x.Year,
                Mileage = x.Mileage,
                Location = x.Location,
                CarModelId = x.CarModelId,
                SteeringWheel = x.SteeringWheel,
                IsCustomClearence = x.IsCustomClearence,
                FuelType = x.FuelType,
                Motor = x.Motor,
                Id = x.Id
            }).ToList();

            return carsDto;
        }

        public GetCarDto GetCar(int id)
        {
            Car car = _appDbContext.Cars.Find(id);

            GetCarDto getCarDto = new GetCarDto
            {
                Year = car.Year,              
                Mileage = car.Mileage,
                Location = car.Location,
                CarModelId = car.CarModelId,
                SteeringWheel = car.SteeringWheel,
                IsCustomClearence = car.IsCustomClearence,
                FuelType = car.FuelType,
                Motor = car.Motor,
                Id = car.Id
            };

            return getCarDto;
        }

        public void Remove(int id)
        {
            Car car = _appDbContext.Cars.Find(id);
            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();
        }
    }
}
