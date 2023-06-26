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
    public class ClassViewModel : ViewModelBase
    {
        private readonly IRepository<Class> classRepo;
        public static ObservableCollection<Class>? Classes { get; set; }
        public static Class Class { get; set; }


        public ClassViewModel(IRepository<Class> classRepo)
        {
            this.classRepo = classRepo;
            if (classRepo is not null)
            {
                Classes = new ObservableCollection<Class>(classRepo.GetAll());
            }
        }



        public RelayCommand RemoveClassCommand
        {
            get => new(() =>
            {
                try
                {
                    classRepo.Remove(Class);
                    Classes?.Remove(Class);
                    classRepo.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            });
        }


        public RelayCommand AddClassCommand
        {
            get => new(() =>
            {
                Window window = new AddClassView();
                window.ShowDialog();
            });
        }



        public RelayCommand EditClassCommand
        {
            get => new(() =>
            {
                Window window = new EditClassView();
                window.ShowDialog();
            });
        }



    }
}
