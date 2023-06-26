using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolBusFinalTask.Presentation.ViewModels;
using System.Runtime.ConstrainedExecution;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    internal class EditCarViewModel : ViewModelBase
    {
        readonly IRepository<Car>? carRepo = new Repository<Car>();



       
        public string? Name { get; set; }
        public string? CarNumber { get; set; }
        public int SeatCount { get; set; }






        #region EditCar
//public RelayCommand EditCarCommand
        //{
        //    get => new RelayCommand(() =>
        //    {
        //        try
        //        {
        //            Car = carRepo.Get(c => c.Id == CarViewModel.Car.Id).FirstOrDefault();

        //            Car.Name = Name;
        //            Car.CarNumber = CarNumber;
        //            Car.SeatCount = SeatCount;

        //            carRepo.Update(Car);
        //            carRepo.SaveChanges();
        //            CarViewModel.Cars.Remove(Car);
        //            CarViewModel.Cars.Add(Car);

        //            CarViewModel.Car = Car;

        //            MessageBox.Show("Car Edited");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            throw;
        //        }

        //    });
        //}
        #endregion
        


        public RelayCommand EditCarCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    Car editedCar = carRepo.Get(c => c.Id == CarViewModel.Car.Id).FirstOrDefault();

                    editedCar.Name = Name;
                    editedCar.CarNumber = CarNumber;
                    editedCar.SeatCount = SeatCount;

                    carRepo.Update(editedCar);
                    carRepo.SaveChanges();

                    CarViewModel.Cars.Remove(CarViewModel.Car);
                    CarViewModel.Cars.Add(editedCar);

                    MessageBox.Show("Car Edited");


                    CarViewModel.Car = editedCar;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            });
        }



    }
}
