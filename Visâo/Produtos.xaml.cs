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
    /// Lógica interna para Produtos.xaml
    /// </summary>
    public partial class Produtos : Window
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void ConsultaL(object sender, RoutedEventArgs e)
        {
            ConsultaL w = new ConsultaL();
            if (w.ShowDialog().Value)
            {
                txtN.Text = w.getnome();
                txtT.Text = w.getp().ToString();
            }
        }

        private void ConsultaC(object sender, RoutedEventArgs e)
        {
            ComsultaC w = new ComsultaC();
            if (w.ShowDialog().Value)
            {
                txtI.Text = w.getid().ToString();
            }
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        public Compras GetP()
        {
            double p = double.Parse(txtT.Text);
            Compras c = new Compras();
            c.IdCliente = int.Parse(txtI.Text);
            c.NomeLivro = txtN.Text;
            try
            {
                c.Quantidade = int.Parse(txtQ.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Você Não colocou um numero em Quantidade");
            }
            try
            {
                c.ValorTotal = p * int.Parse(txtQ.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Você Não colocou um numero em preço");
            }
            return c;
        }
    }
}
