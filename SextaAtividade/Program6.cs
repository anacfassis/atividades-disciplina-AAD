//Dados Heterogêneos
//Vamos criar um vetor de dados heterogêneos. Para isso, criaremos um struct chamado Professor, com os seguintes atributos:
// - Matrícula (string);
// - Nome (string);
// - DadosDisciplina (struct Disciplina);
//A struct Disciplina terá os seguintes atributos:
// - NomeDisciplina (string);
// - CargaHorária (int);

struct Professor
{
    public string Matrícula;
    public string Nome;
    public Disciplina DadosDisciplina;
}

struct Disciplina
{
    public string NomeDisciplina;
    public int CargaHorária;
}

class Program6
{
    static void Main(string[] args)
    {
        Professor[] xProf = new Professor[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("\nMatrícula do Professor: ");
            xProf[i].Matrícula = Console.ReadLine();

            Console.Write("Nome do Professor: ");
            xProf[i].Nome = Console.ReadLine();

            Console.Write("Nome da Disciplina: ");
            xProf[i].DadosDisciplina.NomeDisciplina = Console.ReadLine();

            Console.Write("Carga Horária da Disciplina: ");
            xProf[i].DadosDisciplina.CargaHorária = int.Parse(Console.ReadLine());
        }

        ListarTudo(xProf);

        string Nome;
        bool Achou;

        Console.Write("\nDigite o nome do professor a ser pesquisado: ");

        Nome = Console.ReadLine();

        Achou = ListaProf(xProf, Nome);

        if(!Achou)
        {
            Console.WriteLine("\nProfessor não encontrado!");
        }

        Console.ReadKey();

    }

    static void ListarTudo(Professor[] P)
    {
        Console.Clear();

        foreach (Professor x in P)
        {
            Console.WriteLine($"\n{x.Nome} - ({x.Matrícula})");
            Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
            Console.WriteLine($"Carga Horária: {x.DadosDisciplina.CargaHorária} horas");
        }
        Console.ReadKey();
    }

    static bool ListaProf(Professor[] P, string Nome)
    {
        Console.Clear();

        bool Achou = false;

        foreach (Professor x in P)
        {
            if (x.Nome == Nome)
            {
                Console.WriteLine($"\n{x.Nome} - ({x.Matrícula})");
                Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
                Console.WriteLine($"Carga Horária: {x.DadosDisciplina.CargaHorária} horas");
                
                Achou = true;
            }
        }
        return Achou;
    }
}