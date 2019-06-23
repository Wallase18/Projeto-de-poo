using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PLivros
    {
        private string arquivo = "Livros.xml";
        public List<Livro> Open()
        {
            List<Livro> ls;
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                ls = (List<Livro>)x.Deserialize(f);
            }
            catch
            {
                ls = new List<Livro>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return ls;
        }
        public void Save(List<Livro> ls)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, ls);
            f.Close();
        }
    }
    public class PCliente
    {
        private string arquivo = "Clientes.xml";
        public List<Cliente> Open()
        {
            List<Cliente> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Cliente>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Cliente>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Cliente>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<Cliente> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Cliente>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
    public class PCompra
    {
        private string arquivo = "Compra.xml";
        public List<Compras> Open()
        {
            List<Compras> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Compras>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Compras>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Compras>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<Compras> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Compras>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
