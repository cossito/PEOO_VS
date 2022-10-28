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

namespace Questão01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            abastecimento gomes = new abastecimento();
            gomes.SetKmRodados(double.Parse(txt1.Text));
            gomes.SetValorPago(double.Parse(txt2.Text));
            gomes.SetValorLitro(double.Parse(txt3.Text));
            txt4.Text = gomes.MediaKmLitro().ToString("0.00");
            txt5.Text = gomes.MediaReaisKm().ToString("0.00");
        }
    }
}
