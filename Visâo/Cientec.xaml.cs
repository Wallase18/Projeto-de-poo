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
    /// Lógica interna para Cientec.xaml
    /// </summary>
    public partial class Cientec : Window
    {
        public Cientec()
        {
            InitializeComponent();
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
            CCliente w = new CCliente();
            if (w.ShowDialog().Value)
            {
                NCliente n = new NCliente();
                n.Insert(w.GetCliente());
                grid.ItemsSource = null;
                grid.ItemsSource = n.Select();
            }
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            Cliente C = new Cliente();
            C.IdCliente = int.Parse(txtI.Text);
            NCliente n = new NCliente();
            n.Delete(C);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            Cliente C = new Cliente();
            C.IdCliente = int.Parse(txtI.Text);
            C.NomeCliente = txtN.Text;
            C.Cpf = txtC.Text;
            NCliente n = new NCliente();
            n.Update(C);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Cliente C = grid.SelectedItem as Cliente;
                txtI.Text = C.IdCliente.ToString();
                txtN.Text = C.NomeCliente;
                txtC.Text = C.Cpf;
            }
        }
    }
}
