using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace working_dotnet_reference_values_types
{
    public struct Endereco : IDados
    {
        public Endereco(){}     
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}