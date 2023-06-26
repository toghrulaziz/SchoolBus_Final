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
    public class StudentViewModel : ViewModelBase
    {
        private readonly IRepository<Student> studentRepo;
        public static ObservableCollection<Student>? Students { get; set; }
        public static Student Student { get; set; }
        


        public StudentViewModel(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
            if (studentRepo is not null)
            {
                Students = new ObservableCollection<Student>(studentRepo.GetAll());
            }
        }

        public RelayCommand RemoveStudentCommand
        {
            get => new(() =>
            {
                try
                {
                    studentRepo.Remove(Student);
                    Students?.Remove(Student);
                    studentRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }




        public RelayCommand AddStudentCommand
        {
            get => new(() =>
            {
                Window window = new AddStudentView();
                window.ShowDialog();
            });
        }


        


        public RelayCommand EditStudentCommand
        {
            get => new(() =>
            {
                Window window = new EditStudentView();
                window.ShowDialog();
            });
        }


    }
}
