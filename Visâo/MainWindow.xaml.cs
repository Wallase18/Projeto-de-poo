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

namespace Visâo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Livros(object sender, RoutedEventArgs e)
        {
            Livros W = new Livros();
            W.ShowDialog();
        }

        private void Cliente(object sender, RoutedEventArgs e)
        {
            Cientec W = new Cientec();
            W.ShowDialog();
        }

        private void Venda(object sender, RoutedEventArgs e)
        {
            Compra w = new Compra();
            w.ShowDialog();
        }
    }
}
