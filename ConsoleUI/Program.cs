using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddTest();
            //DeleteTest();
            //BrandAddTest();
            //CarAddTest();
            //ColorAddTest();
            //CarUpdateTest();
            
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car
            {
                CarId = 1,
                BrandId = 1,
                CarName = "Mustang",
                ColorId = 3,
                ModelYear = 1967,
                DailyPrice = 1299,
                Description = "V8 350HP Manual"
            });
            Console.WriteLine(Messages.Updated);
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                ColorName = "Gümüş"
            });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarName = "Mustang",
                BrandId = 1,
                ColorId = 1,
                DailyPrice=1350,
                Description="6V 480 bg"
            });
            Console.WriteLine(Messages.Added);
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandName = "Tesla"
            });
        }

        private static void DeleteTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new User
            {
                Id = 2
            }); ;
            Console.WriteLine(Messages.Deleted);
        }

        private static void AddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Tuğba",
                LastName = "Aktaş",
                Email = "tubaaktas83@gmail.com",
                Password = "147852369"
            });
            Console.WriteLine(Messages.Added);
        }

    }
}
