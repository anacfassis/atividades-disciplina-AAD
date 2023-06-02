//Desenvolva uma classe que, por meio de métodos, realize as seguintes operações dentro de um vetor de números inteiros:
// - Criação de um vetor de dimensões fornecidas pelo usuário segundo um método construtor. Se não for fornecido pelo usuário o tamanho deverá ser, por padrão, 10;
// - Criação de um vetor de dimensões fornecidas pelo usuário e inserção automática de valores aleatórios nesse vetor, segundo um método construtor, fornecidos os limites mínimo e máximo; Se não fornecido o tamanho do vetor pelo usuário o tamanho deverá ser 10;
// - Listagem de todos os elementos do vetor;
// - Inserção de um valor em uma dada posição do vetor;
// - Recuperação de um valor indicado por uma posição fornecida pelo usuário;
// - Localização do Maior e do Menor número dentro do vetor.
// - Teste as rotinas no programa principal (main).

class Vetor
{
    private int[] _Vetor;     // Vetor de inteiros
    private int Tamanho;     // Tamanho do vetor

    public Vetor()    // Construtor
    {
        Tamanho = 10;            // Tamanho padrão

        _Vetor = new int[Tamanho];   // Cria o vetor
    }

    public Vetor(int T)    // Construtor 2
    {
        this.Tamanho = T;            // Usuário define o tamanho

        _Vetor = new int[Tamanho];   // Cria o vetor
    }

    public Vetor(int LInf, int LSup)       // Construtor 3
    {
        Tamanho = 10;            // Tamanho padrão e aleatório

        _Vetor = new int[Tamanho];   // Cria o vetor

        Random Rnd = new Random();

        for (int i = 0; i < Tamanho; i++)
        {
            _Vetor[i] = Rnd.Next(LInf, LSup + 1);
        }
    }
    
    public Vetor(int T, int LInf, int LSup)       // Construtor 4
    {
        this.Tamanho = T;            // Usuário define o tamanho e aleatório

        _Vetor = new int[Tamanho];   // Cria o vetor

        Random Rnd = new Random();

        for (int i = 0; i < Tamanho; i++)
        {
            _Vetor[i] = Rnd.Next(LInf, LSup + 1);
        }
    }

    public void InsereValor(int Pos, int Valor)
    {
        _Vetor[Pos] = Valor;
    }

    public int RecuperaValor(int Pos)
    {
        return _Vetor[Pos];
    }

    public int MaiorValor()
    {
        int Maior = _Vetor[0];

        for (int i = 1; i < Tamanho; i++)
        {
            if (_Vetor[i] > Maior)
            {
                Maior = _Vetor[i];
            }
        }

        return Maior;
    }

    public int MenorValor()
    {
        int Menor = _Vetor[0];

        for (int i = 1; i < Tamanho; i++)
        {
            if (_Vetor[i] < Menor)
            {
                Menor = _Vetor[i];
            }
        }

        return Menor;
    }

    public void MostraVetor()
    {
        Console.WriteLine();

        foreach (int N in _Vetor)
        {
            Console.Write($"{N,5} ");
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}

class Program16
{
    static void Main(string[] args)
    {
        Vetor V1 = new Vetor();

        V1.MostraVetor();

        V1.InsereValor(0, 92);
        V1.InsereValor(2, 45);
        V1.InsereValor(3, 21);
        V1.InsereValor(7, 89);

        V1.MostraVetor();
        
        Vetor V2 = new Vetor(5);

        V2.InsereValor(0, 76);
        V2.InsereValor(2, 12);
        V2.InsereValor(3, 65);

        V2.MostraVetor();
        
        Vetor V3 = new Vetor(8, 1, 50);

        V3.MostraVetor();

        Console.WriteLine($"\n    O Elemento da Posição 3 do vetor é {V3.RecuperaValor(3)}");

        V3.MostraVetor();
        
        Console.WriteLine($"\n    O Maior Elemento do vetor é {V3.MaiorValor()}");
        Console.WriteLine($"\n    O Menor Elemento do vetor é {V3.MenorValor()}");

        Console.ReadKey();

    }
}