using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using working_dotnet_reference_values_types;
using static System.Console;
public class Program
{
    //Exemplo 1
    static void Exemplo1()
    {
        int a = 2;
        Adicionar20(ref a);
        WriteLine($"O valor da variável é {a}");

        static void Adicionar20(ref int x)
        {
            x += 20;
        }

    }



    //Exemplo 2
    static void Exemplo2(){
        var nomes = new string[]{"Henrique", "Carlos", "Ricardo"};
        WriteLine($@"A lista de nomes é: 
            {string.Join(", \n",nomes)}
        ");

        WriteLine("Digite o nome a ser substituido:");
        var nome = ReadLine();
        WriteLine("Qual nome novo:");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes Alterada é: 
            {string.Join(", \n",nomes)}
        ");

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (var i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }
    }


    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (var i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                return ref nomes[i];
            }
        }
        
        throw new Exception("Nome não encontrado");
    }

    static void Main()
    {
        var nomes = new string[]{"Henrique", "Carlos", "Ricardo"};
        WriteLine($@"A lista de nomes é: 
            {string.Join(", \n",nomes)}
        ");

        WriteLine("Digite o nome a ser substituido:");
        var nome = ReadLine();

        ref var nomeEncontrado = ref LocalizarNome(nomes, nome);
        
        WriteLine("Qual nome novo:");
        var nomeNovo = ReadLine();
        nomeEncontrado = nomeNovo;

        WriteLine($@"A lista de nomes Alterada é: 
            {string.Join(", \n",nomes)}
        ");
    }   
}