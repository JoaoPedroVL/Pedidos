using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entidades
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Valor { get; set; }
        public Produto(string name, double valor)
        {
            Name = name;
            Valor = valor;
        }
    }
}
