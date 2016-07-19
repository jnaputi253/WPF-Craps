using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MoveLine()
        {
            /*while (Math.Abs(Line.Y2 - Window.Height) > 0.000001)
            {
                Line.X2 += 10;
                Line.Y2 += 10;
                Line.InvalidateArrange();
                Thread.Sleep(1000);
            }*/
            Line.X2 += 1;
            Line.Y2 += 10;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MoveLine();
        }
    }
}
