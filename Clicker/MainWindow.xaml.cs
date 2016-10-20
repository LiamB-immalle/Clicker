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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clicker
{

    public partial class MainWindow : Window
    {
        int a = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (a < 10)
            {
                a = a + 1;
                textBlock.Text = String.Format("{0}", a);
                return;
            } 
            if (a < 20) {
                a = a + 2;
                textBlock.Text = String.Format("{0}", a);
                return;
            }
            if (a < 30)
            {
                a = a + 5;
                textBlock.Text = String.Format("{0}", a);
                return;
            }
            if (a < 40)
            {

                a = a + 10;
                textBlock.Text = String.Format("{0}", a);
                return;
            }
            if (a < 50)
            {

                a = a + 50;
                textBlock.Text = String.Format("{0}", a);
                return;
            }
            else
            {
                a = a + 100;
                textBlock.Text = String.Format("{0}", a);
                return;
            }
        }

    }
}
