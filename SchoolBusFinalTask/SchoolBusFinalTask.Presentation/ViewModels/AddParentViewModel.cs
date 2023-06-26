using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SchoolBusFinalTask.Presentation.ViewModels;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    internal class AddParentViewModel : ViewModelBase
    {
        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();

        public Parent? _NewParent = new();

        public Parent? NewParent
        {
            get { return _NewParent; }
            set { Set(ref _NewParent, value); }
        }


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }



        public RelayCommand SubmitCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    NewParent = new() { FirstName = FirstName, LastName = LastName, PhoneNumber = Phone, UserName = UserName, Password = Password};
                    ParentViewModel.Parents.Add(NewParent);
                    parentRepo.Add(NewParent);
                    parentRepo.SaveChanges();
                    MessageBox.Show("Parent Added");
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


    }
}
