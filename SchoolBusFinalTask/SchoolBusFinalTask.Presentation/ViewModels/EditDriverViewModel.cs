using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolBusFinalTask.Presentation.ViewModels;
using System.Windows;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    internal class EditDriverViewModel : ViewModelBase
    {
        readonly IRepository<Driver>? driverRepo = new Repository<Driver>();



        public IEnumerable<Car>? Cars { get; set; } = new Repository<Car>().Get(c => c.Driver == null);


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool License { get; set; }
        public string? HomeAddress { get; set; }
        public Car? Car { get; set; }
        public int CarId { get; set; }




        public RelayCommand EditDriverCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    Driver editedDriver = driverRepo.Get(d => d.Id == DriverViewModel.Driver.Id).FirstOrDefault();

                    editedDriver.FirstName = FirstName;
                    editedDriver.LastName = LastName;
                    editedDriver.PhoneNumber = Phone;
                    editedDriver.UserName = UserName;
                    editedDriver.Password = Password;
                    editedDriver.HasLicence = License;
                    editedDriver.Address = HomeAddress;
                    editedDriver.Car = Car;
                    

                    driverRepo.Update(editedDriver);
                    driverRepo.SaveChanges();

                    DriverViewModel.Drivers.Remove(DriverViewModel.Driver);
                    DriverViewModel.Drivers.Add(editedDriver);

                    MessageBox.Show("Driver Edited");


                    DriverViewModel.Driver = editedDriver;


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
