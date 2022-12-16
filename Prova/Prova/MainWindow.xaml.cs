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

namespace Prova
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

        private Escola x = new Escola();
        private Disciplina nome;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nome = new Disciplina(txt_1.Text, int.Parse(txt_2.Text));
            nome.SetNome(txt_1.Text);
            nome.SetMedia(int.Parse(txt_2.Text));
            x.Inserir(nome);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Disciplina i in x.Listar())
                txt_3.Text += $"{i.ToString()}\n";
        }
    }
}
