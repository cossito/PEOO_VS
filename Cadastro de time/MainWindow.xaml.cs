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

namespace Cadastro_de_time
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

        private Time nome;

        private void button_criar_Click(object sender, RoutedEventArgs e)
        {
            nome = new Time();
            nome.SetNome(txt_1.Text);
            nome.SetEstado(txt_2.Text);
        }

        private void button_inserir_Click(object sender, RoutedEventArgs e)
        {
            Jogador x = new Jogador();
            x.SetNome(txt_3.Text);
            x.SetCamisa(txt_4.Text);
            x.SetGols(int.Parse(txt_5.Text));
            nome.Inserir(x);
        }

        private void button_listar_Click(object sender, RoutedEventArgs e)
        {
            foreach (Jogador i in nome.Listar())
                txt_list.Text += $"{i.ToString()}\n";
        }

        private void button_art_Click(object sender, RoutedEventArgs e)
        {
            txt_art.Text = nome.ToString();
        }
    }
}
