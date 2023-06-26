using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    internal class AddDriverViewModel : ViewModelBase
    {

        //readonly IRepository<Car>? carRepo = new Repository<Car>();


        readonly IRepository<Driver>? driverRepo = new Repository<Driver>();

        public Driver? _NewDriver = new();

        public IEnumerable<Car>? Cars { get; set; } = new Repository<Car>().Get(c => c.Driver == null);


        public Driver? NewDriver
        {
            get { return _NewDriver; }
            set { Set(ref _NewDriver, value); }
        }


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool License { get; set; }
        public string? HomeAddress { get; set; }
        public Car? Car { get; set; }
        public int CarId { get; set; }

        public RelayCommand SubmitCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    NewDriver = new() { FirstName = FirstName, LastName = LastName, PhoneNumber = Phone, UserName = UserName,Password = Password, HasLicence = License, Address = HomeAddress, CarId = Car.Id };
                    DriverViewModel.Drivers.Add(NewDriver);
                    driverRepo.Add(NewDriver);
                    driverRepo.SaveChanges();
                    MessageBox.Show("Driver Added");
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


    }
}
