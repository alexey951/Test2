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
using System.Windows.Shapes;
using WpfApp2.View.Pages;

namespace WpfApp2.View.Windows
{
    public partial class MainWindow : Window
    {
        public static Frame Frame { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Frame = MainFrame;
            Frame.Navigate(new LoginPage());
        }
    }
}
