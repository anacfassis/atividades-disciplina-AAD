// Um professor tem uma turma com 50 alunos. Ele vai dar no semestre 3 avaliações. Faça um programa que lance a nota de cada aluno nessas avaliações (considere lançar apenas para 5 alunos para agilizar, claro...).
//a.    Mostre a nota total de cada aluno
//b.    Mostre a média da nota da turma em cada uma das provas

class Program4
{
    static void Main(string[] args)
    {
        int[,] Notas = new int[5, 3]; //Matriz para as notas
        
        for (int i = 0; i < 5; i++) //Para cada prova
        {
            Console.Write($"\nAluno {i + 1}\n");
            for (int j = 0; j < 3; j++) //Para cada aluno
            {
                Console.Write($"   Nota da Prova {j + 1}: ");
                Notas[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int Soma; //Vetor para as somas
        double Média; //Vetor para as médias

        Console.Clear();

        for (int i = 0; i < 5; i++) //Para cada aluno
        {
            Soma = 0; //Zera a soma

            for (int j = 0; j < 3; j++) //Para cada prova
            {
                Soma += Notas[i, j]; //Acumula a nota na soma
            }
            Console.WriteLine($"Nota Final do Aluno {i + 1}: {Soma,3}");
        }

        Console.WriteLine("\n");

        for (int i = 0; i < 3; i++) //Para cada prova
        {
            Soma = 0; //Zera a soma
            for (int j = 0; j < 5; j++) //Para cada aluno
            {
                Soma += Notas[j, i]; //Acumula a nota na soma
            }
            Console.WriteLine($"Média da Turma na Prova {i + 1}: {((double)Soma / 5),2:F2}");
        }

        Console.ReadKey();

    }

}