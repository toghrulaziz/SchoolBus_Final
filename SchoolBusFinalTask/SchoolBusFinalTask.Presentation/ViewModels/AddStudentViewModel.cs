using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using SchoolBusFinalTask.Presentation.ViewModels;
using System.Windows;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    internal class AddStudentViewModel : ViewModelBase
    {
        readonly IRepository<Student>? studentRepo = new Repository<Student>();
        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();
        readonly IRepository<Class>? classRepo = new Repository<Class>();

        private Student? _NewStudent = new();

        public IEnumerable<Class>? Classes { get; set; } = new Repository<Class>().GetAll();
        public IEnumerable<Parent>? Parents { get; set; } = new Repository<Parent>().GetAll();

        

        public Student? NewStudent
        {
            get { return _NewStudent; }
            set { Set(ref _NewStudent, value); }
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Parent? Parent { get; set; }
        public Class? Class { get; set; }
        public string HomeAddress { get; set; }
        public string OtherAddress { get; set; }


        public RelayCommand SubmitCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    //NewStudent = new() { FirstName = FirstName, LastName = LastName, Class = Class, HomeAddress = HomeAddress, OtherAddress = OtherAddress, Parent = Parent };

                    NewStudent.FirstName = FirstName;
                    NewStudent.LastName = LastName;
                    NewStudent.ClassId = Class.Id;
                    NewStudent.HomeAddress = HomeAddress;
                    NewStudent.OtherAddress = OtherAddress;
                    NewStudent.ParentId = Parent.Id;
                    

                    


                    StudentViewModel.Students.Add(NewStudent);

                    studentRepo.Add(NewStudent);
                    studentRepo.SaveChanges();

                    //parentRepo.Update(Parent);
                    //parentRepo.SaveChanges();

                    //classRepo.Update(Class);
                    //classRepo.SaveChanges();

                    MessageBox.Show("Student Added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }


            });
        }




    }
}
