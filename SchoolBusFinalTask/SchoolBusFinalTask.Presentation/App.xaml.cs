using GalaSoft.MvvmLight.Messaging;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using SchoolBusFinalTask.Presentation.ViewModels;
using SchoolBusFinalTask.Presentation.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBusFinalTask.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            Window window = new MainWindow();
            var viewModel = Container.GetInstance<MainViewModel>();
            window.DataContext = viewModel;
            window.ShowDialog();

            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<Services.INavigationService, Services.NavigationService>();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<IRepository<Car>, Repository<Car>>();
            Container.RegisterSingleton<IRepository<Driver>, Repository<Driver>>();
            Container.RegisterSingleton<IRepository<Student>, Repository<Student>>();
            Container.RegisterSingleton<IRepository<Parent>, Repository<Parent>>();
            Container.RegisterSingleton<IRepository<Class>, Repository<Class>>();
            Container.RegisterSingleton<IRepository<Ride>, Repository<Ride>>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<StudentViewModel>();
            Container.RegisterSingleton<ParentViewModel>();
            Container.RegisterSingleton<DriverViewModel>();
            Container.RegisterSingleton<CarViewModel>();
            Container.RegisterSingleton<ClassViewModel>();
            Container.RegisterSingleton<RidesViewModel>();
            Container.RegisterSingleton<HolidaysViewModel>();
            Container.RegisterSingleton<AddDriverViewModel>();
            Container.RegisterSingleton<AddCarViewModel>();
            Container.RegisterSingleton<AddParentViewModel>();
            Container.RegisterSingleton<AddStudentViewModel>();
            Container.RegisterSingleton<AddClassViewModel>();
            Container.RegisterSingleton<EditCarViewModel>();
            Container.RegisterSingleton<EditDriverViewModel>();
            Container.RegisterSingleton<EditParentViewModel>();
            Container.RegisterSingleton<EditClassViewModel>();
            Container.RegisterSingleton<CreateRideViewModel>();
            Container.RegisterSingleton<EditStudentViewModel>();
        }
    }
}
