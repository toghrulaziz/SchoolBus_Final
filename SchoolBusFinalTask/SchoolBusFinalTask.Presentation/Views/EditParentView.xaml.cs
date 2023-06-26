﻿using SchoolBusFinalTask.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SchoolBusFinalTask.Presentation.Views
{
    /// <summary>
    /// Interaction logic for EditParentView.xaml
    /// </summary>
    public partial class EditParentView : Window
    {
        public EditParentView()
        {
            InitializeComponent();
            DataContext = new EditParentViewModel();
        }
    }
}
