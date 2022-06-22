using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public double Valor { get; set; }
        public int Codigo { get; set; }
    }
}
