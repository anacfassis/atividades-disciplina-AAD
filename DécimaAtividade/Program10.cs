//Faça um programa que possa ser usado por uma clínica para cadastrar: 30 pacientes, a data da consulta, a hora de sua realização, o nome de um paciente e o nome do médico que o atenderá. Depois de os dados serem informados, o programa deve conter uma opção que, o usuário fornecendo o nome do médico, liste toda a agenda dele.
//Considere que o atributo "Data da consulta” seja também estruturado, formado pelos campos Dia, Mês e Ano.

class Paciente
{
    public string NomePaciente;
    public Data DataConsulta;
    public string HoraConsulta;
    public string NomeMédico;
}

class Data
{
    public string Dia;
    public string Mês;
    public string Ano;
}

class Program10
{
    static void Main(string[] args)
    {
        Paciente[] CadPaciente = new Paciente[3];    //Cadastrando 3 pacientes como exemplo
        
        for (int i = 0; i < 3; i++)
        {
            Paciente x = new Paciente();
            
            Console.Write($"\nNome do Paciente {i + 1}: ");
            x.NomePaciente = Console.ReadLine();

            Console.Write("Nome do Médico: ");
            x.NomeMédico = Console.ReadLine();

            x.DataConsulta = new Data();
            
            Console.Write("Data da Consulta - Dia: ");
            x.DataConsulta.Dia = Console.ReadLine();
            
            Console.Write("                   Mês: ");
            x.DataConsulta.Mês = Console.ReadLine();

            Console.Write("                   Ano: ");
            x.DataConsulta.Ano = Console.ReadLine();

            Console.Write("Hora da Consulta: ");
            x.HoraConsulta = Console.ReadLine();
            
            
            CadPaciente[i] = x;
        }

        Console.Clear();

        string NomeMédico;

        Console.Write("\nDigite o nome do médico para listar a agenda: ");
        NomeMédico = (Console.ReadLine());

        foreach (Paciente P in CadPaciente)
        {
            if (P.NomeMédico == NomeMédico)
            {
            Console.WriteLine($"\nNome do Paciente: {P.NomePaciente}");
            Console.WriteLine($"Data da consulta: {P.DataConsulta.Dia}/" + $"{P.DataConsulta.Mês}/" + $"{P.DataConsulta.Ano} - " + $"{P.HoraConsulta} horas");
            }
        }

        Console.ReadKey();
}
}