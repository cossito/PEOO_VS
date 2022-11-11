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

namespace Questão06
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtNumBolas.Text = slider.Value.ToString();
        }

        private Bingo b;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = new Bingo();
            b.Iniciar(int.Parse(txtNumBolas.Text));
            iniciar.IsEnabled = false;
            sortear.IsEnabled = true;
            numSorteio.Clear();
            numSorteados.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x = b.Sortear();
            if (x == -1)
            {
                numSorteio.Text = "Fim";
                iniciar.IsEnabled = true;
                sortear.IsEnabled = false;
            }
            else
            {
                numSorteio.Text = x.ToString();
                string s = "";
                foreach (int i in b.Sorteados())
                    s = s + i + " - ";
                numSorteados.Text = s;
            }
        }
    }
}