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
    /// Lógica interna para ComsultaC.xaml
    /// </summary>
    public partial class ComsultaC : Window
    {
        public ComsultaC()
        {
            InitializeComponent();
            Cliente C = new Cliente();
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
        public int getid()
        {
            Compras c = new Compras() ;
            c.IdCliente = int.Parse(txtI.Text);
            return c.IdCliente;
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
