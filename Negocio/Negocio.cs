using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NLivros
    {
        public List<Livro> Select()
        {
            PLivros p = new PLivros();
            return p.Open();
        }
        public List<Livro> Select(string s)
        {
            PLivros p = new PLivros();
            List<Livro> cs = p.Open();
            return cs.Where(x => x.NomeLivro.StartsWith(s)).ToList();
        }
        public void Insert(Livro c)
        {
            PLivros p = new PLivros();
            List<Livro> cs = p.Open();
            int Id = 1;
            if (cs.Count > 0) Id = cs.Max(x => x.id) + 1;
            c.id = Id;
            cs.Add(c);
            p.Save(cs);
        }

        public void Update(Livro c)
        {
            PLivros p = new PLivros();
            List<Livro> cs = p.Open();
            try
            {
                Livro r = cs.Where(x => x.id == c.id).Single();
                cs.Remove(r);
                cs.Add(c);
                p.Save(cs);
            }
            catch(InvalidOperationException)
            {

            }
        }

        public void Delete(Livro c)
        {
            PLivros p = new PLivros();
            List<Livro> cs = p.Open();
            try
            {
                Livro r = cs.Where(x => x.id == c.id).Single();
                cs.Remove(r);
                p.Save(cs);
            }
            catch (InvalidOperationException)
            {

            }
        }
    }
    public class NCliente
    {
        public List<Cliente> Select()
        {
            PCliente p = new PCliente();
            return p.Open();
        }
        public List<Cliente> Select(string s)
        {
            PCliente p = new PCliente();
            List<Cliente> cs = p.Open();
            return cs.Where(x => x.NomeCliente.StartsWith(s)).ToList();
        }
        public void Insert(Cliente c)
        {
            PCliente p = new PCliente();
            List<Cliente> cs = p.Open();
            int Id = 1;
            if (cs.Count > 0) Id = cs.Max(x => x.IdCliente) + 1;
            c.IdCliente = Id;
            cs.Add(c);
            p.Save(cs);
        }

        public void Update(Cliente c)
        {
            PCliente p = new PCliente();
            List<Cliente> cs = p.Open();
            try
            {
                Cliente r = cs.Where(x => x.IdCliente == c.IdCliente).Single();
                cs.Remove(r);
                cs.Add(c);
                p.Save(cs);
            }
            catch (InvalidOperationException)
            {

            }
        }

        public void Delete(Cliente c)
        {
            PCliente p = new PCliente();
            List<Cliente> cs = p.Open();
            try
            {
                Cliente r = cs.Where(x => x.IdCliente == c.IdCliente).Single();
                cs.Remove(r);
                p.Save(cs);
            }
            catch (InvalidOperationException)
            {

            }
        }
    }
    public class NCompras
    {
        public List<Compras> Select()
        {
            PCompra p = new PCompra();
            return p.Open();
        }
        public List<Compras> Select(string s)
        {
            PCompra p = new PCompra();
            List<Compras> cs = p.Open();
            return cs.Where(x => x.NomeLivro.StartsWith(s)).ToList();
        }
        public void Insert(Compras c)
        {
            PCompra p = new PCompra();
            List<Compras> cs = p.Open();
            int Id = 1;
            if (cs.Count > 0) Id = cs.Max(x => x.IdCliente) + 1;
            c.IdCliente = Id;
            cs.Add(c);
            p.Save(cs);
        }

        public void Update(Compras c)
        {
            PCompra p = new PCompra();
            List<Compras> cs = p.Open();
            Compras r = cs.Where(x => x.IdCliente == c.IdCliente).Single();
            cs.Remove(r);
            cs.Add(c);
            p.Save(cs);
        }

        public void Delete(Compras c)
        {
            PCompra p = new PCompra();
            List<Compras> cs = p.Open();
            Compras r = cs.Where(x => x.IdCliente == c.IdCliente).Single();
            cs.Remove(r);
            p.Save(cs);
        }
    }
}
