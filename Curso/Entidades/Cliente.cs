using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }

        public Cliente(string nome, string email, DateTime data) 
        {
            Nome = nome;
            Email = email;
            Data = data;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cliente: {Nome} ({Data}) - {Email}");
            return sb.ToString();
        }
    }
}
