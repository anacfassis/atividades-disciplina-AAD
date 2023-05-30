//Faça um programa que possa cadastrar o nome e o telefone de 30 funcionários de uma empresa. Depois dos dados serem informados o programa deve conter uma opção que sirva para o usuário pesquisar sequencialmente um funcionário e encontrar o seu telefone. Se o funcionário não estiver cadastrado, o programa deve informar que o funcionário não existe. O programa deve ser feito usando matriz.

class Program
{
    static void Main(string[] args)
    {
        string[,] Cadastro = new string[5, 2]; //Matriz para os dados
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"\nNome do Funcionário {i + 1}: "); //Para cada funcionário
            Cadastro[i, 0] = Console.ReadLine();
            Console.Write($"Telefone...............: "); //Para cada telefone
            Cadastro[i, 1] = Console.ReadLine();
        }
        string Nome;
        bool Achou = false;
        
        Console.Write("\n\nDigite o Nome de um Funcionário: "); 
        Nome = Console.ReadLine();
        
        for (int i = 0; i < 5; i++)
        {
            if (Cadastro[i, 0] == Nome) //Pesquisa sequencial
            {
                Achou = true;
                Console.WriteLine($"O Telefone desse Funcionário é { Cadastro[i, 1]} .");
            }
        }
        if (!Achou)
            Console.WriteLine("Funcionário não Cadastrado."); //Se não achou, avisa
        Console.ReadKey();
    }
}

