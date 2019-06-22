using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Livro
    {
        public int id { get; set; }
        public string NomeLivro { get; set; }
        public int Quantidade { get; set; }
        public string Editora { get; set; }
        public double Preço { get; set; }
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
    }
    public class Compra
    {
        public int IdCliente { get; set; }
        public string NomeLivro { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}
