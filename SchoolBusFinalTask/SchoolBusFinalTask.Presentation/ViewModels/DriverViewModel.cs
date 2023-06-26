using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using SchoolBusFinalTask.Presentation.Services;
using SchoolBusFinalTask.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    public class DriverViewModel : ViewModelBase
    {
        private readonly IRepository<Driver> driverRepo;
        public static ObservableCollection<Driver> Drivers { get; set; }
        public static Driver Driver { get; set; }


        public DriverViewModel(IRepository<Driver> driverRepo)
        {
            this.driverRepo = driverRepo;
            if (driverRepo is not null)
            {
                Drivers = new ObservableCollection<Driver>(driverRepo.GetAll());
            }
        }



        public RelayCommand RemoveDriverCommand
        {
            get => new(() =>
            {
                try
                {
                    driverRepo.Remove(Driver);
                    Drivers?.Remove(Driver);
                    driverRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


        public RelayCommand AddDriverCommand
        {
            get => new(() =>
            {
                Window window = new AddDriverView();
                window.Show();

            });
        }



        public RelayCommand EditDriverCommand
        {
            get => new(() =>
            {
                Window window = new EditDriverView();
                window.ShowDialog();
            });
        }







    }
}
