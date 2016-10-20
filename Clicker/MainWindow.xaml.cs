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

            if (a < 200)
            {
                a = a + 1;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("1 per klik");
                return;
            } 
            if (a < 500) {
                a = a + 2;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("2 per klik");
                return;
            }
            if (a < 1500)
            {
                a = a + 5;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("5 per klik");
                return;
            }
            if (a < 4000)
            {

                a = a + 10;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("10 per klik");
                return;
            }
            if (a < 10000)
            {

                a = a + 50;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("50 per klik");
                return;
            }
            else
            {
                a = a + 100;
                textBlock.Text = String.Format("{0}", a);
                multiplier.Text = ("100 per klik");
                return;
            }
        }

    }
}
