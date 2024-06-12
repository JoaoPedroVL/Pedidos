using System;
using Curso.Entidades;
using Curso.Entidades.Menu;


namespace Curso
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
    
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Quantos pedidos vao ser ? ");
            int i = int.Parse(Console.ReadLine());




            //Construtor cliente
            Cliente cliente = new Cliente(nome, Email, dateTime);
            //pedido construtor
            Pedido pedido = new Pedido(dateTime, os, cliente);

            for (int j = 1; j <= i; j++)
            {
                Console.WriteLine($"Enter #{j} item data");

                Console.Write("Product name: ");
                string proName = Console.ReadLine();

                Console.Write("preço: ");
                double proPreco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int proQuantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(proName, proPreco); //produto construtor
                PedidoItem pedidoitem = new PedidoItem(proQuantidade, proPreco, produto); // Pedido Construtor
                pedido.AddItem(pedidoitem);


            }
            Console.WriteLine("ORDER SUMMARY: ");
            //pedido.ToString();
            //cliente.ToString();
            Console.WriteLine(pedido.ToString()); 

        }
    }
}