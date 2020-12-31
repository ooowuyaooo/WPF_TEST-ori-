﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for SecondPageView.xaml
    /// </summary>
    public partial class SecondPageView : UserControl
    {
        public SecondPageView()
        {
            InitializeComponent();
            this.DataContext = new CoursePageViewModel();
        }
    }
}
