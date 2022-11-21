using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Konversi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int c, r, f, k;

        private void Fahrenheit_Click(object sender, RoutedEventArgs e)
        {
            f = Convert.ToInt32(Angka.Text);
            c = (f - 32) * 5 / 9;
            r = (f - 32) * 4 / 9;
            k = (f - 32) * 5 / 9 + 273;

            Fahrenheitb.Text = Angka.Text;
            Celciusb.Text = Convert.ToString(c);
            Reaumurb.Text = Convert.ToString(r);
            Kelvinb.Text = Convert.ToString(k);
        }

        private void Reaumur_Click(object sender, RoutedEventArgs e)
        {
            r = Convert.ToInt32(Angka.Text);
            c = (r * 5) / 4;
            k = (r * 5 / 4) + 273;
            f = (r * 9 / 4) + 32;

            Reaumurb.Text = Angka.Text;
            Celciusb.Text = Convert.ToString(c);
            Kelvinb.Text = Convert.ToString(k);
            Fahrenheitb.Text = Convert.ToString(f);
        }

        private void Kelvin_Click(object sender, RoutedEventArgs e)
        {
            k = Convert.ToInt32(Angka.Text);
            c = k - 273;
            f = (k - 273) * 9 / 5 + 32;
            r = (k - 273 * 4) / 5;

            Kelvinb.Text = Angka.Text;
            Celciusb.Text = Convert.ToString(c);
            Reaumurb.Text = Convert.ToString(r);
            Fahrenheitb.Text = Convert.ToString(f);
        }

        public void Keluar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Apakah anda ingin keluar?", "Exit Program", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                result = MessageBox.Show("Anda yakin ingin keluar?", "Exit Program", MessageBoxButtons.YesNo);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    App.Current.Shutdown();
                }
                else 
                {
                }
            }
            else
            {

            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Celcius_Click(object sender, RoutedEventArgs e)
        {
            c = Convert.ToInt32(Angka.Text);
            r = (c * 4) / 5;
            f = (c * 9 / 5) + 32;
            k = (c + 273);

            Celciusb.Text = Angka.Text;
            Fahrenheitb.Text = Convert.ToString(f);
            Reaumurb.Text = Convert.ToString(r);
            Kelvinb.Text = Convert.ToString(k);

        }
    }
}
