//Criação de um programa para cadastrar 3 veículos com as seguintes informações: Nome, Marca, AnoFab, Placa e PreçoFIP.

class Veículo       //Classe de Tipo
{
    public string Nome;
    public string Marca;
    public string AnoFab;
    public string Placa;
    public double PreçoFIP;
}

class Program9
{
    static void Main(string[] args)
    {
        //Vetor para "armazenar" os veículos
        Veículo[] CadVeículo = new Veículo[3];     //3 veículos para exemplo

        for (int i = 0; i < 3; i++)
        {
            Veículo x = new Veículo();      //Instanciando um objeto da classe Veículo

            //Lendo os dados do veículo
            Console.Write($"\nNome do Veículo {i + 1}: ");
            x.Nome = Console.ReadLine();

            Console.Write("Marca do Veículo: ");
            x.Marca = Console.ReadLine();

            Console.Write("Ano de Fabricação: ");
            x.AnoFab = Console.ReadLine();

            Console.Write("Placa do Veículo: ");
            x.Placa = Console.ReadLine();

            Console.Write("Preço FIP: ");
            x.PreçoFIP = double.Parse(Console.ReadLine());

            //Armazenando o veículo x no vetor, posição i
            CadVeículo[i] = x;      //Cadastrou o veículo x na posição i
        }

        Console.Clear();

        //Mostrando os dados dos veículos cadastrados
        foreach (Veículo V in CadVeículo)
        {
            Console.WriteLine($"\nNome: {V.Nome} - Ano: {V.AnoFab}");
            Console.WriteLine($"Marca: {V.Marca}");
            Console.WriteLine($"Placa: {V.Placa}");
            Console.WriteLine($"Preço - Tabela FIP: R${V.PreçoFIP:F2}");
        }   

        Console.ReadKey();

    }
}