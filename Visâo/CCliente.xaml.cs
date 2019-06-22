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

namespace Visâo
{
    /// <summary>
    /// Lógica interna para CCliente.xaml
    /// </summary>
    public partial class CCliente : Window
    {
        public CCliente()
        {
            InitializeComponent();
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        public Cliente GetCliente()
        {
            Cliente C = new Cliente();
            C.IdCliente = 0;
            C.NomeCliente = txtN.Text;
            C.Cpf = txtC.Text;
            return C;
        }
    }
}
