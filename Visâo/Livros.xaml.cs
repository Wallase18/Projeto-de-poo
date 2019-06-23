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
    /// Lógica interna para Livros.xaml
    /// </summary>
    public partial class Livros : Window
    {
        public Livros()
        {
            InitializeComponent();
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
            CLivros w = new CLivros();
            if (w.ShowDialog().Value)
            {
                NLivros n = new NLivros();
                n.Insert(w.GetLivro());
                grid.ItemsSource = null;
                grid.ItemsSource = n.Select();
            }
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            try
            {
                l.id = int.Parse(txtI.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é possivel exclui sem o ID");
            }
            NLivros n = new NLivros();
            n.Delete(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            try
            {
                l.id = int.Parse(txtI.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não é um numero");
            }
            l.NomeLivro = txtN.Text;
            try
            {
                l.Quantidade = int.Parse(txtQ.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Você Não colocou um numero em Quantidade");
            }
            l.Editora = txtE.Text;
            try
            {
                l.Preço = double.Parse(txtP.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Você Não colocou um numero em preço");
            }
            NLivros n = new NLivros();
            n.Update(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
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
    }
}
