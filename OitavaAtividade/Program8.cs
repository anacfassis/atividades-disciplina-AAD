//Repita o programa da atividade 7, agora considerando que a data de validade é de um tipo estruturado e formado pelos campos mês e ano.

struct Produto
{
    public string Nome;
    public decimal Preço;
    public int QtdeEstoque;
    public Data Validade;
}

struct Data
{
    public int Mês;
    public int Ano;
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

            Console.Write($"Digite o mês de validade do produto: ");
            xProd[i].Validade.Mês = int.Parse(Console.ReadLine());

            Console.Write($"Digite o ano de validade do produto: ");
            xProd[i].Validade.Ano = int.Parse(Console.ReadLine());
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
            Console.WriteLine($"Mês de Validade: {x.Validade.Mês}");
            Console.WriteLine($"Ano de Validade: {x.Validade.Ano}");
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
                Console.WriteLine($"Mês de Validade: {x.Validade.Mês}");
                Console.WriteLine($"Ano de Validade: {x.Validade.Ano}");

                Achou = true;
            }
        }

        return Achou;
    }
}
