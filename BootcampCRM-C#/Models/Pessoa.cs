using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampCRM_C_.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(String nome){
            Nome = nome;
        }

        public Pessoa (String nome, String sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}