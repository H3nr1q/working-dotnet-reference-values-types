using working_dotnet_reference_values_types;
using static System.Console;

//Exemplo1

Pessoa p1 = new Pessoa
{
    Idade = 31,
    Nome = "Henrique",
    EnderecoPessoa = new Endereco{
        Logradouro = "R. Mario Bettoni",
        Numero = 137,
        CEP = "15900-000",
        Cidade = "Taquaritinga"
    }
};

WriteLine("Fim");