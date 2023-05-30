    //1) Faça um programa que leia o valor dos elementos de um vetor de inteiros com 10 posições. Depois que os dados forem fornecidos o programa deverá:
    //a.    Mostrar o maior e o menor valor do vetor
    //b.    Mostrar quantos números pares e quantos números ímpares existem no vetor
    //c.    Mostrar a média aritmética dos valores do vetor

    class Program3
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1} do Vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.WriteLine($"O Maior Valor do Vetor é {AchaMaior(Vetor)}");
            Console.WriteLine($"O Menor Valor do Vetor é {AchaMenor(Vetor)}");
            Console.WriteLine($"Existem {ContaPares(Vetor)} elementos Pares no Vetor");
            Console.WriteLine($"Existem {ContaÍmpares(Vetor)} elementos Ímpares no Vetor");
            Console.WriteLine($"A Média Aritmética dos elementos do vetor é {AchaMédia(Vetor):F2}");

            Console.ReadKey();
        }
        static int AchaMaior(int[] V)
        {
            int Maior = V[0];
            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] > Maior)
                    Maior = V[i];
            }
            return Maior;
        }
        static int AchaMenor(int[] V)
        {
            int Menor = V[0];
            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] < Menor)
                    Menor = V[i];
            }
            return Menor;
        }
        static int ContaPares(int[] V)
        {
            int Pares = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)
                    Pares++;
            }
            return Pares;
        }
        static int ContaÍmpares(int[] V)
        {
            int Ímpares = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 != 0)
                    Ímpares++;
            }
            return Ímpares;
        }
        static double AchaMédia(int[] V)
        {
            int Soma = 0;
            double Média;
            for (int i = 0; i < V.Length; i++)
            {
                Soma += V[i];
            }
            return (double)Soma / V.Length;
        }
    }