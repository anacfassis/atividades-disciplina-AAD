//Faça um programa que defina de forma completa uma classe de Nome “Veículo” com os atributos “Modelo”, “Marca”, “Ano de Fabricação” e “Placa”. Crie métodos capazes de ler os dados de um veículo e mostrar uma listagem de todos os veículos.
//Cadastre em um vetor 30 veículos.

class Veículo
{
    private string _Modelo;
    public string Modelo
    {
        get { return _Modelo; }
        set { _Modelo = value; }
    }

    private string _Marca;

    public string Marca
    {
        get { return _Marca; }
        set { _Marca = value; }
    }

    private string _AnoFabricação;

    public string AnoFabricação
    {
        get { return _AnoFabricação; }
        set { _AnoFabricação = value; }
    }

    private string _Placa;

    public string Placa
    {
        get { return _Placa; }
        set { _Placa = value; }
    }

    public void CadastrarVeículo()
    {
        Console.Clear();

            Console.Write($"\nModelo do veículo: ");
            _Modelo = Console.ReadLine();

            Console.Write("Marca do veículo: ");
            _Marca = Console.ReadLine();

            Console.Write("Ano de fabricação do veículo: ");
            _AnoFabricação = Console.ReadLine();

            Console.Write("Placa do veículo: ");
            _Placa = Console.ReadLine();
    }

    public void ListaDados()
    {
        Console.WriteLine($"\n{_Marca} {_Modelo}");
        Console.WriteLine($"Placa {_Placa} - Ano de fabricação: {_AnoFabricação}");
    }

}

class Program12
{
    static void Main(string[] args)
    {
        Veículo[] veículos = new Veículo[3];            //Vetor de 3 veículos como exemplo

        for (int i = 0; i < 3; i++)
        {
            Veículo x = new Veículo();                 //Instanciando um objeto da classe Veículo
                                                       // x é um objeto e sabe ler os dados de um veículo...
            x.CadastrarVeículo();
                                                      // Nesse momento x já possui todos os dados lidos
                                                     // Vamos armazenar no vetor...
            veículos[i] = x;
        }
        
        Console.Clear();

        foreach (Veículo V in veículos)
        {
                                                   // Para cada veículo V no cadastro...
            V.ListaDados();
        }
        
        Console.ReadKey();
    }
}
