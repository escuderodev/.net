using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.src.models
{
    public class Pessoa
    {
        public string name { get; set; }
        public int age { get; set; }

        public void apresentar() {
            Console.WriteLine($"Meu nome é {this.name} e tenho {this.age} anos!");
        }
    }
}