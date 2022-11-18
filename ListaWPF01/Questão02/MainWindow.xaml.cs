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

namespace Questão02
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
            contato x = new contato(txt1.Text, txt2.Text, txt3.Text);
            lista.Items.Add(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedItems != null) lista.Items.Remove(lista.SelectedItem);
        }
    }
}
