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
using System.Windows.Shapes;
using Modelo;
using Negocio;

namespace Visâo
{
    /// <summary>
    /// Lógica interna para ConsultaL.xaml
    /// </summary>
    public partial class ConsultaL : Window
    {
        public ConsultaL()
        {
            InitializeComponent();
            Livro l = new Livro();
            NLivros n = new NLivros();
            n.Update(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }
        public string getnome()
        {
            Compras c = new Compras();
            c.NomeLivro = txtN.Text;
            return c.NomeLivro;
        }
        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Livro L = grid.SelectedItem as Livro;
                txtI.Text = L.id.ToString();
                txtN.Text = L.NomeLivro;
                txtQ.Text = L.Quantidade.ToString();
                txtE.Text = L.Editora;
                txtP.Text = L.Preço.ToString();
            }
        }
        public double getp()
        {
            Compras c2 = new Compras();
            c2.ValorTotal = double.Parse(txtP.Text);
            return c2.ValorTotal;
        }
        private void Confirmar(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
