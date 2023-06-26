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
    internal class EditClassViewModel : ViewModelBase
    {
        readonly IRepository<Class>? classRepo = new Repository<Class>();


        public string? Name { get; set; }



        public RelayCommand EditClassCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    Class editedClass = classRepo.Get(c => c.Id == ClassViewModel.Class.Id).FirstOrDefault();


                    editedClass.Name = Name;
                    


                    classRepo.Update(editedClass);
                    classRepo.SaveChanges();

                    ClassViewModel.Classes.Remove(ClassViewModel.Class);
                    ClassViewModel.Classes.Add(editedClass);

                    MessageBox.Show("Class Edited");


                    ClassViewModel.Class = editedClass;


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
