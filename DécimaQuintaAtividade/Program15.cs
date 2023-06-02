//Vamos criar um programa que leia os dados de 3 funcionários, utilizando uma classe chamada Funcionário. A classe deverá ter os atributos ID, Nome e Salário. O ID deverá ser gerado automaticamente. O Nome e o Salário deverão ser lidos pelo programa. Ao final, o programa deverá mostrar os dados dos 3 funcionários. Utilizamos construtores para criação do programa.




class Funcionário
{

    private string _ID;

    public string ID
    {
        get { return _ID; }
        //set { _ID = value; }
    }

    private string _Nome;

    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }

    private double _Salário;

    public double Salário
    {
        get { return _Salário; }
        set { _Salário = value; }
    }

    // Construtores
    public Funcionário()
    {
        // Gera um ID aleatório - Guid.NewGuid() gera um ID único composto por letras e números, porém, como é muito extenso, transformamos em ToString() e, como continua extenso, pegamos os 4 caracteres a partir da posição 4 com o Substring(4, 4) e converte para maiúsculo com o ToUpper()

        _ID = Guid.NewGuid().ToString().Substring(4, 4).ToUpper();
    }

    public Funcionário(string id)              //Alteramos o parâmetro para string id
    {
        _ID = id;
    }
}

class Program15
{
    static void Main(string[] args)
    {
        Funcionário[] CadFunc = new Funcionário[3];

        for (int i = 0; i < 3; i++)
        {
            Funcionário xFunc = new Funcionário();

            Console.WriteLine($"\nFuncionário {i + 1} - ID {xFunc.ID}:");

            Console.Write("Nome: ");
            xFunc.Nome = Console.ReadLine();

            Console.Write("Salário (R$): ");
            xFunc.Salário = double.Parse(Console.ReadLine());

            CadFunc[i] = xFunc;
        }

        Console.Clear();

        foreach (Funcionário F in CadFunc)
        {
            Console.WriteLine($"\n{F.Nome} ({F.ID})");
            Console.WriteLine($"Salário: R$ {F.Salário:F2}");
        }

        Console.ReadKey();
    }
}