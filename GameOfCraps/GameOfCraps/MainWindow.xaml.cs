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

namespace GameOfCraps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Start button");
        }

        private void RestartButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Restart button");
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_OnClick(object sender, RoutedEventArgs e)
        {
            string message = string.Format("Name: Juan Naputi\n" +
                                           "Version: {0}\n" +
                                           "Extra Stuff", typeof (MainWindow).Assembly.GetName().Version);
            MessageBox.Show(message);
        }
    }
}
