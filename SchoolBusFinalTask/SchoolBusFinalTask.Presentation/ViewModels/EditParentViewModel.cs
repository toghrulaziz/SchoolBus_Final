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
    internal class EditParentViewModel : ViewModelBase
    {
        readonly IRepository<Parent>? parentRepo = new Repository<Parent>();


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }





        public RelayCommand EditParentCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    Parent editedParent = parentRepo.Get(p => p.Id == ParentViewModel.Parent.Id).FirstOrDefault();


                    editedParent.FirstName = FirstName;
                    editedParent.LastName = LastName;
                    editedParent.PhoneNumber = Phone;
                    editedParent.UserName = UserName;
                    editedParent.Password = Password;
                    

                    parentRepo.Update(editedParent);
                    parentRepo.SaveChanges();

                    ParentViewModel.Parents.Remove(ParentViewModel.Parent);
                    ParentViewModel.Parents.Add(editedParent);

                    MessageBox.Show("Parent Edited");


                    ParentViewModel.Parent = editedParent;


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
