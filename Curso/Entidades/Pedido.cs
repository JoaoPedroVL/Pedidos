using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entidades.Menu;

namespace Curso.Entidades
{
    internal class Pedido
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<PedidoItem> PedidoItem { get; set; } = new List<PedidoItem>();

        public Pedido(DateTime date, OrderStatus status)
        {
            Date = date;
            status = status;
        }

        public void AddItem(PedidoItem item)
        {
            PedidoItem.Add(item);
        }
        public void RemoveItem(PedidoItem item)
        {
            PedidoItem.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(PedidoItem Item in PedidoItem)
            {
                total += Item.SubTotal();
            }
            return total;
        }



    }
}
