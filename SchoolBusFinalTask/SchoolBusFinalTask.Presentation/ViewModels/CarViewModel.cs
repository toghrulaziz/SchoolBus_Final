using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using SchoolBusFinalTask.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    public class CarViewModel : ViewModelBase
    {
        private readonly IRepository<Car> carRepo;
        public static ObservableCollection<Car> Cars { get; set; }
        public static Car Car { get; set; }


        public CarViewModel(IRepository<Car> carRepo)
        {
            this.carRepo = carRepo;
            if (carRepo is not null)
            {
                Cars = new ObservableCollection<Car>(carRepo.GetAll());
            }
        }


        public RelayCommand RemoveCarCommand
        {
            get => new(() =>
            {
                try
                {
                    carRepo.Remove(Car);
                    Cars?.Remove(Car);
                    carRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


        public RelayCommand AddCarCommand
        {
            get => new(() =>
            {
                Window window = new AddCarView();
                window.ShowDialog();
            });
        }


        public RelayCommand EditCarCommand
        {
            get => new(() =>
            {
                Window window = new EditCarView();
                window.ShowDialog();
            });
        }


    }
}
