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

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    public class RidesViewModel : ViewModelBase
    {
        private readonly IRepository<Ride> rideRepo;
        public static ObservableCollection<Ride>? Rides { get; set; }
        public static Ride? Ride { get; set; }


        public RidesViewModel(IRepository<Ride> rideRepo)
        {
            this.rideRepo = rideRepo;
            if (rideRepo is not null)
            {
                Rides = new ObservableCollection<Ride>(rideRepo.GetAll());
            }
        }


        public RelayCommand RemoveRideCommand
        {
            get => new(() =>
            {
                try
                {
                    rideRepo.Remove(Ride);
                    Rides?.Remove(Ride);
                    rideRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


    }
}
