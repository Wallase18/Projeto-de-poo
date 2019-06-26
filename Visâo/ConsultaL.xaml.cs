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

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Livro L = grid.SelectedItem as Livro;
        }
    }
}
