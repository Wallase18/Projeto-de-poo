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
    /// Lógica interna para Compra.xaml
    /// </summary>
    public partial class Compra : Window
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
             Compras c = new Compras();
            try
            {
                c.IdCliente = int.Parse(txtI.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            c.NomeLivro = txtN.Text;
            try
            {
                c.Quantidade = int.Parse(txtQ.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            try
            {
                c.ValorTotal = double.Parse(txtT.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            NCompras n = new NCompras();
             n.Insert(c);
             grid.ItemsSource = null;
             grid.ItemsSource = n.Select();
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            Compras l = new Compras();
            l.IdCliente = int.Parse(txtI.Text);
            NCompras n = new NCompras();
            n.Delete(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            Compras c = new Compras();
            try
            {
                c.IdCliente = int.Parse(txtI.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            c.NomeLivro = txtN.Text;
            try
            {
                c.Quantidade = int.Parse(txtQ.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            try
            {
                c.ValorTotal = double.Parse(txtT.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            NCompras n = new NCompras();
            n.Update(c);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Compras c = grid.SelectedItem as Compras;
                txtI.Text = c.IdCliente.ToString();
                txtN.Text = c.NomeLivro;
                txtQ.Text = c.Quantidade.ToString();
                txtT.Text = c.ValorTotal.ToString();
            }
        }

        private void ConsultaL(object sender, RoutedEventArgs e)
        {
            ConsultaL w = new ConsultaL();
            w.ShowDialog();
        }

        private void ConsultaC(object sender, RoutedEventArgs e)
        {
            ComsultaC w = new ComsultaC();
            w.ShowDialog();
        }
    }
}
