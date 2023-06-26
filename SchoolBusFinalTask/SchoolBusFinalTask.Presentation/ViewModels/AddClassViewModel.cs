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
    internal class AddClassViewModel : ViewModelBase
    {
        readonly IRepository<Class>? classRepo = new Repository<Class>();

        public Class? _NewClass = new();

        public Class? NewClass
        {
            get { return _NewClass; }
            set { Set(ref _NewClass, value); }
        }


        public string? Name { get; set; }


        public RelayCommand SubmitCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    NewClass = new() { Name = Name };
                    ClassViewModel.Classes.Add(NewClass);
                    classRepo.Add(NewClass);
                    classRepo.SaveChanges();
                    MessageBox.Show("Class Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }



    }
}
