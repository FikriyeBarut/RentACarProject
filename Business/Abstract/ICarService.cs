using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll(); //tümünü listeler
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByDailyPrice(float ucret);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<CarDetailDto> GetCarDetails();

    }
}
