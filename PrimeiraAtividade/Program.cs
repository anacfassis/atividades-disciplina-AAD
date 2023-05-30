//Criaremos um vetor de números inteiros com 5 posições e ler cada um de seus valores. Criaremos duas funções que, tomando esse vetor como parâmetro, irão retornar a soma dos números pares contidos no vetor e a quantidade de números ímpares que ele possui. Exibiremos os resultados obtidos no programa principal.

class Program
{
    static void Main(string[] args)
    {
        //Declaração do vetor
        int[] Vetor = new int[5];

        //Entrada de elementos do vetor
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º Elemento do Vetor ");
            Vetor[i] = int.Parse(Console.ReadLine());
        }

        //Variáveis para a Soma e para a Quantidade
        int Soma;
        int Qtde;

        Soma = SomaPares(Vetor);

        Qtde = ContaImpares(Vetor);

        //Agora é só exibir os resultados
        Console.WriteLine();

        Console.WriteLine($"A soma dos elementos pares é {Soma}");
        Console.WriteLine($"A quantidade de elementos ímpares é {Qtde}");

        Console.ReadKey();
    }

    //Funções
    static int SomaPares(int[] V)
    {
        int S = 0; //Variável para a soma dos pares
        for (int i = 0; i < 5; i++) //Para cada elemeto do vetor
        {
            if (V[i] % 2 == 0) //Se o elemento for par
            {
                S += V[i]; //Soma o elemento
            }
        }
        return S; //Retorna a soma
    }

    static int ContaImpares(int[] V)
    {
        int Q = 0; //Variável para a quantidade de ímpares
        for (int i = 0; i < V.Length; i++) //Para cada elemento do vetor
        {
            if (V[i] % 2 != 0) //Se o elemento for ímpar
            {
                Q++; //Incrementa a quantidade
            }
        }
        return Q; //Retorna a quantidade
    }
}
