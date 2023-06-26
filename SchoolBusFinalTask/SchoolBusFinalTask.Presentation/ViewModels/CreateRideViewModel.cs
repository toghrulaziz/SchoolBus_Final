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
using SchoolBusFinalTask.Presentation.ViewModels;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    public class CreateRideViewModel : ViewModelBase
    {

        readonly IRepository<Ride>? rideRepo = new Repository<Ride>();
        readonly IRepository<Student>? studentRepo = new Repository<Student>();

        public Ride? _NewRide = new();

        public Ride? NewRide
        {
            get { return _NewRide; }
            set { Set(ref _NewRide, value); }
        }




        public IEnumerable<Driver>? Drivers { get; set; } = new Repository<Driver>().GetAll();



        private Driver? selectedDriver;
        public Driver? SelectedDriver
        {
            get { return selectedDriver; }
            set { Set(ref selectedDriver, value); }
        }





        private int? studentsAttend = 0;
        public int? StudentsAttend
        {
            get { return studentsAttend; }
            set { Set(ref studentsAttend, value); }
        }









        public ObservableCollection<Student>? Students { get; set; } = new ObservableCollection<Student>(new Repository<Student>().Get(s => s.Ride == null));


        private Student? selectedStudent;
        public Student? SelectedStudent
        {
            get { return selectedStudent; }
            set { Set(ref selectedStudent, value); }
        }


        public ObservableCollection<Student> AttendStudents { get; set; } = new ObservableCollection<Student>();


        private Student? attendStudent;
        public Student? AttendStudent
        {
            get { return attendStudent; }
            set { Set(ref attendStudent, value); }
        }





        public RelayCommand CreateRideCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    if (SelectedDriver.Car.SeatCount >= StudentsAttend)
                    {
                        if (AttendStudents != null)
                        {
                            NewRide.DriverId = SelectedDriver.Id;

                            foreach (var item in AttendStudents)
                            {
                                NewRide.ClassId = item.ClassId;
                            }
                            
                            
                            

                            RidesViewModel.Rides.Add(NewRide);
                            rideRepo.Add(NewRide);
                            rideRepo.SaveChanges();

                            foreach (var item in AttendStudents)
                            {
                                item.RideId = NewRide.Id;
                                studentRepo.Update(item);
                                studentRepo.SaveChanges();
                            }



                            MessageBox.Show("Ride Created");
                        }
                        else
                            MessageBox.Show("AttendStudents is null");

                    }
                    else
                        MessageBox.Show("The number of participating students is more than the number of seats");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

            });
        }






        public RelayCommand AddStudentCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    if (SelectedStudent != null)
                    {
                        if (SelectedDriver.Car.SeatCount >= StudentsAttend)
                        {
                            var temp = SelectedStudent;
                            AttendStudents!.Add(temp);
                            Students!.Remove(temp);
                            StudentsAttend++;
                            
                            
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }




        public RelayCommand RemoveStudentCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    if (AttendStudent != null)
                    {
                        var temp = AttendStudent;
                        Students!.Add(temp);
                        AttendStudents!.Remove(temp);
                        StudentsAttend--;
                    }
                    else
                        MessageBox.Show("Test");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }






    }
}
