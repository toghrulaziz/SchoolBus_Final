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
    internal class EditStudentViewModel : ViewModelBase
    {
        readonly IRepository<Student>? studentRepo = new Repository<Student>();



        public IEnumerable<Parent>? Parents { get; set; } = new Repository<Parent>().GetAll();
        public IEnumerable<Class>? Classes { get; set; } = new Repository<Class>().GetAll();


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Parent? Parent { get; set; }
        public Class? Class { get; set; }
        public string HomeAddress { get; set; }
        public string OtherAddress { get; set; }



        public RelayCommand EditStudentCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    Student editedStudent = studentRepo.Get(s => s.Id == StudentViewModel.Student.Id).FirstOrDefault();


                    editedStudent.FirstName = FirstName;
                    editedStudent.LastName = LastName;
                    editedStudent.Parent = Parent;
                    editedStudent.Class = Class;
                    editedStudent.HomeAddress = HomeAddress;
                    editedStudent.OtherAddress = OtherAddress;
                    


                    studentRepo.Update(editedStudent);
                    studentRepo.SaveChanges();

                    StudentViewModel.Students.Remove(StudentViewModel.Student);
                    StudentViewModel.Students.Add(editedStudent);

                    MessageBox.Show("Student Edited");


                    StudentViewModel.Student = editedStudent;


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
