using MyCars.DTO;
using MyCars.Entities;
using System.Collections.Generic;

namespace MyCars.Interfaces
{
    public interface IMyCarRepository
    {
        void Create(CreateCarDto car);
        GetCarDto GetCar(int id);
        List<GetAllCarsDto> GetAllCars();
        CarEditDto Edit(CarEditDto carEditDto);
        void Remove(int id);
    }
}
