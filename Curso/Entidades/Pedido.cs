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
        public List<PedidoItem> pedidoitem { get; set; } = new List<PedidoItem>();
        public Cliente Cliente { get; set; }

        public Pedido(DateTime date, OrderStatus status, Cliente cliente)
        {
            Date = date;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem item)
        {
            pedidoitem.Add(item);
        }
        public void RemoveItem(PedidoItem item)
        {
            pedidoitem.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(PedidoItem Item in pedidoitem)
            {
                total += Item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment : {Date.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Order Status : {Status}");
            sb.AppendLine($"Cliente : {Cliente}");
            sb.Append("Order Item : ");
            foreach(PedidoItem item in pedidoitem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${Total().ToString()}");
            return sb.ToString();

        }


    }
}
