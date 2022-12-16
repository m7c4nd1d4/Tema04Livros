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

namespace Tema04Livros
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

        private Genero k;

        private void bgenero_Click_1(object sender, RoutedEventArgs e)
        {
            k = new Genero(txtgenero.Text);
            binserir.IsEnabled = true;
            bcalc.IsEnabled = false;
            blistar.IsEnabled = false;

        }

        private void blistar_Click_1(object sender, RoutedEventArgs e)
        {
            txtlista.ItemsSource = null;
            txtlista.ItemsSource = k.Listar();

        }

        private void binserir_Click_1(object sender, RoutedEventArgs e)
        {
            Livro x = new Livro(txtnomelivro.Text, txtautor.Text, double.Parse(txtvalor.Text));
            k.Inserir(x);
            bcalc.IsEnabled = true;
            blistar.IsEnabled = true;
            txtnomelivro.Clear();
            txtautor.Clear();
            txtvalor.Clear();

        }

        private void bcalc_Click_1(object sender, RoutedEventArgs e)
        {
            txtmenorpreco.Text = k.MenorPreco().ToString();
        }
    }
}
