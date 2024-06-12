using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entidades
{
    internal class PedidoItem
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public Produto Produto { get; set; }

        public PedidoItem()
        {

        }
        public PedidoItem(int quantidade, double valor, Produto produto) 
        {
            Quantidade = quantidade;
            Valor = valor;
            Produto = produto;

        }

        public double SubTotal()
        {
            return Valor * Quantidade; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append($"{Produto.Name}, Quantidade: {Quantidade}, Price: {Valor}, SubTotal: ${SubTotal()}");
            return sb.ToString();
        }

        
    }
}
