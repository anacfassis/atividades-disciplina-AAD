//Vamos fazer um programa que irá ler os dados de uma matriz de inteiros de ordem 5, ou seja, de dimensões 5x5. Matematicamente ela é chama de matriz quadrada, porque o número de “linhas” é igual ao número de “colunas”. Depois de darmos entrada nos valores da matriz chamaremos uma função que, tomando essa matriz como parâmetro, retornará um vetor composto pelos elementos da diagonal principal dessa matriz quando, então, os listaremos.


class Program2
{

    static void Main(string[] args)
    {
       //Exemplo de Matriz
       
        //    5   8   3   2   9
         //   1   7   6   4   0
        //    2   3   5   8   1
        //    9   4   7   6   3
         //   0   1   2   3   4
       
       // Diagonal Principal da Matriz: 5, 7, 5, 6, 4

       int[,] Matriz = new int[5, 5]; //Declaração da Matriz
       int[] VetorResultante = new int[5]; //Declaração do Vetor Resultante

       for (int i = 0; i < 5; i++) //Para cada linha da Matriz
       {
           for (int j = 0; j < 5; j++) //Para cada coluna da Matriz
           {
               Console.Write($"Elemento ({i + 1}, {j + 1}): ");

               Matriz[i, j] = int.Parse(Console.ReadLine()); //Lê o valor do elemento
           }
       }

       //Chamada à Função
       // Envia a Matriz e recebe o Vetor Resultante
         VetorResultante = DiagonalPrincipal(Matriz);

         //Exibe o Vetor Resultante
         Console.Write("\n\nDiagonal Principal: ");

         for (int i = 0; i < 5; i++)  //Para cada coluna da Matriz
         {
             Console.Write($"{VetorResultante[i], 7}");
         }

         Console.WriteLine("\n");

         Console.ReadKey();

    }

    static int[] DiagonalPrincipal(int[,] M)
    {
        int[] Result = new int[5];       //Declaração do Vetor Resultante

        for (int i = 0; i < 5; i++)      //Para cada linha da Matriz
        {
           for (int j = 0; j < 5; j++)   //Para cada coluna da Matriz
           {
               if (i == j)               //Se o elemento estiver na diagonal principal
               {
                   Result[i] = M[i, j];  //Copia o elemento para o Vetor Resultante
               }
           }
        }

        // for (int i = 0; i < 5; i++)      //Para cada linha da Matriz
        // {
        //     Result[i] = M[i, i];         //Copia o elemento para o Vetor Resultante
        // }

        return Result; //Retorna o Vetor Resultante
    }
}
