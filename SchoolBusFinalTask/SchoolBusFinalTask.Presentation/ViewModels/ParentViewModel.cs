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
    public class ParentViewModel : ViewModelBase
    {
        private readonly IRepository<Parent> parentRepo;
        public static ObservableCollection<Parent> Parents { get; set; }
        public static Parent Parent { get; set; }


        public ParentViewModel(IRepository<Parent> parentRepo)
        {
            this.parentRepo = parentRepo;
            if (parentRepo is not null)
            {
                Parents = new ObservableCollection<Parent>(parentRepo.GetAll());
            }
        }



        public RelayCommand RemoveParentCommand
        {
            get => new(() =>
            {
                try
                {
                    parentRepo.Remove(Parent);
                    Parents?.Remove(Parent);
                    parentRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }



        public RelayCommand AddParentCommand
        {
            get => new(() =>
            {
                Window window = new AddParentView();
                window.ShowDialog();
            });
        }





        public RelayCommand EditParentCommand
        {
            get => new(() =>
            {
                Window window = new EditParentView();
                window.ShowDialog();
            });
        }





    }
}
