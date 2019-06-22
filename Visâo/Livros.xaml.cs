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
            l.id = int.Parse(txtI.Text);
            NLivros n = new NLivros();
            n.Delete(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            l.id = int.Parse(txtI.Text);
            l.NomeLivro = txtN.Text;
            l.Quantidade = int.Parse(txtQ.Text);
            l.Editora = txtE.Text;
            l.Preço = double.Parse(txtP.Text);
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
