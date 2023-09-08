using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using working_dotnet_reference_values_types;
using static System.Console;
public class Program
{
    public void Teste1()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável é {a}");
    }

    public void Teste2(){
        Pessoa p1 = new(21, "Carla", "231321312");

        Pessoa p2 = p1.CopyFrom();
        
        TrocaNome(p1, "Clara");

        WriteLine($"Nome de p1= {p1.Nome} e nome de p2= {p2.Nome}");
    }

    public void Teste3(){
        StructPessoa p1 = new(21, "Carlos", "1324654");   

        StructPessoa p2 = p1;

        p1 = TrocaNome(p1, "Henrique");

        WriteLine($"Nome de p1= {p1.Nome} e nome de p2= {p2.Nome}");
    }

    public void Teste4()
    {
        string nome = "Henrique";

        TrocaNome(nome, "Rique");
        
        WriteLine($"Nome é {nome}");
    }

    public void Teste5()
    {
        int[] pares = new int[]{0,2,4,6,8};

        mudarParaImpar(pares);

        WriteLine($"Os impares {string.Join(",", pares)}");
    }

    private static void Teste6()
    {
        int[] numeros = new int[] { 0, 2, 4, 6, 8 };
        WriteLine("Digite o numero que gostaria de encontrar:");
        int numero = Int32.Parse(ReadLine());
        int idxEncontrado = buscarNumero(numeros, numero);

        if (idxEncontrado < 0)
        {
            WriteLine($"O numero digitado não foi encontrado");
        }
        else
        {
            WriteLine($"O numero digitado esta na posição {idxEncontrado}");
        }
    }

    static int Adicionar20(int x)
    {
        return x + 20;
    }
    static void TrocaNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }

    static StructPessoa TrocaNome(StructPessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
        return p1;
    }

    static void TrocaNome(string nome, string novoNome){
        nome = novoNome;
    }

    static void mudarParaImpar(int[] pares)
    {
        for(int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i]+1;
        }
    }

    static int buscarNumero(int[] array, int numero)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
    
    static void Main()
    {
        List<Pessoa> pessoas = new()
        {
            new Pessoa(){Nome = "Henrique"},
            new Pessoa(){Nome = "Ronaldo"},
            new Pessoa(){Nome = "Carlos"},
            new Pessoa(){Nome = "Mario"},
            new Pessoa(){Nome = "AAAAAAAAA"}
        };

        WriteLine("Digite a pessoa que deseja buscar:");
        string nomeBuscado = ReadLine();

        var resultado = buscaNome(pessoas, nomeBuscado);

        if(resultado)
        {
            WriteLine("Pessoa localizada");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }

    }

    private static bool buscaNome(List<Pessoa> pessoas, string nomeBuscado)
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == nomeBuscado)
                return true;
        } 
        return false;
    }
}