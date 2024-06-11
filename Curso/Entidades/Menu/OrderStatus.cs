using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entidades.Menu
{
    internal enum OrderStatus : int
    {   
        Pedido_pago = 0,
        Processando,
        Enviado,
        Entregue
    }
}
