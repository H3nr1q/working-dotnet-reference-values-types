using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace working_dotnet_reference_values_types
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(int idade, string nome, string documento)
        {
            Idade = idade;
            Nome = nome;
            Documento = documento;
        }

        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }

        public Pessoa CopyFrom() 
        {
            return new Pessoa(){
                Documento = this.Documento,
                Nome = this.Nome,
                Idade = this.Idade
            };
        }
    }
}