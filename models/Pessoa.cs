using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos_net.models
{
    public class Pessoa
    {
        public required string Name { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Idade} anos.");
        }
    }
}