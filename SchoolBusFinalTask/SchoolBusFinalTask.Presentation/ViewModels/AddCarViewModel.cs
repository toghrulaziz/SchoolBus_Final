using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolBusFinalTask.Presentation.ViewModels;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    internal class AddCarViewModel : ViewModelBase
    {

        readonly IRepository<Car>? carRepo = new Repository<Car>();

        public Car? _NewCar = new();

        public Car? NewCar
        {
            get { return _NewCar; }
            set { Set(ref _NewCar, value); }
        }

        public string? Name { get; set; }
        public string? CarNumber { get; set; }
        public int SeatCount { get; set; }


        public RelayCommand SubmitCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    NewCar = new() { Name = Name, CarNumber = CarNumber, SeatCount = SeatCount };
                    CarViewModel.Cars.Add(NewCar);
                    carRepo.Add(NewCar);
                    carRepo.SaveChanges();
                    MessageBox.Show("Car Added");
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


    }
}
