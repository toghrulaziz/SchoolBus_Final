using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SchoolBusFinalTask.Data.Repos;
using SchoolBusFinalTask.Models.Concretes;
using SchoolBusFinalTask.Presentation.Messages;
using SchoolBusFinalTask.Presentation.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SchoolBusFinalTask.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationService navigationService;
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }

        public MainViewModel(IMessenger messenger, INavigationService navigation)
        {
            navigationService = navigation;
            messenger.Register<NavigationMessage>(this,
                message =>
                {
                    var viewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                    CurrentViewModel = viewModel;
                });
        }

        public RelayCommand StudentViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<StudentViewModel>();
            });
        }


        public RelayCommand ParentViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<ParentViewModel>();
            });
        }



        public RelayCommand DriverViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<DriverViewModel>();
            });
        }


        public RelayCommand CarViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CarViewModel>();
            });
        }



        public RelayCommand ClassViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<ClassViewModel>();
            });
        }



        public RelayCommand RidesViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<RidesViewModel>();
            });
        }




        public RelayCommand HolidaysViewCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<HolidaysViewModel>();
            });
        }




        public RelayCommand CreateRideCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CreateRideViewModel>();
            });
        }







    }
}
