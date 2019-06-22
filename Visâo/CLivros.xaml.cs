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
    /// Lógica interna para CLivros.xaml
    /// </summary>
    public partial class CLivros : Window
    {
        public CLivros()
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
        public Livro GetLivro()
        {
            Livro L = new Livro();
            L.id = 0;
            L.NomeLivro = txtN.Text;
            L.Quantidade = int.Parse(txtQ.Text);
            L.Editora = txtE.Text;
            L.Preço = double.Parse(txtP.Text);
            return L;
        }
    }
}
