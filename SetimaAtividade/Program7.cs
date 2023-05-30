//Faça um programa com um menu de opções que possa cadastrar o nome, o preço unitário, a quantidade em estoque e a data de validade (mês e ano) de 30 produtos. Depois dos dados serem informados, o programa deve conter uma opção que, por meio de uma função, possa listar os produtos acima de um determinado valor fornecido pelo usuário.

struct Produto
{
    public string Nome;
    public decimal Preço;
    public int QtdeEstoque;
    public string Validade;
}

class Program7
{
    static void Main(string[] args)
    {
        Produto[] xProd = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nDigite o nome do produto: ");
            xProd[i].Nome = Console.ReadLine();

            Console.Write($"Digite o preço do produto: R$");
            xProd[i].Preço = decimal.Parse(Console.ReadLine());

            Console.Write($"Digite a quantidade em estoque do produto: ");
            xProd[i].QtdeEstoque = int.Parse(Console.ReadLine());

            Console.Write($"Digite a validade do produto: ");
            xProd[i].Validade = Console.ReadLine();
        }

        ListarTudo(xProd);
        
        decimal Valor;
        bool Achou;

        Console.Write($"\nDigite o valor para filtrar os produtos: R$");

        Valor = decimal.Parse(Console.ReadLine());

        Achou = ListaProd(xProd, Valor);

        if (!Achou)
        {
            Console.WriteLine($"\nNenhum produto encontrado com valor acima de R${Valor}");
        }

        Console.ReadKey();

    }
    static void ListarTudo(Produto[] P)
    {
        Console.Clear();

        foreach (Produto x in P)
        {
            Console.WriteLine($"\n{x.Nome} - R${x.Preço}");
            Console.WriteLine($"Quantidade em estoque: {x.QtdeEstoque}");
            Console.WriteLine($"Validade: {x.Validade}");
        }

        Console.ReadKey();
    }

    static bool ListaProd(Produto[] P, decimal V)
    {
        Console.Clear();

        bool Achou = false;

        foreach (Produto x in P)
        {
            if (x.Preço > V)
            {
                Console.WriteLine($"\n{x.Nome} - R${x.Preço}");
                Console.WriteLine($"Quantidade em estoque: {x.QtdeEstoque}");
                Console.WriteLine($"Validade: {x.Validade}");
                
                Achou = true;
            }
        }

        return Achou;
    }
}



