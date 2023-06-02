class Eq2Grau                               //Classe para trabalhar com uma equação de 2º grau
{
    private double _a;
    public double a
    {
        get { return _a; }
        set { _a = value; }
    }
    
    private double _b;

    public double b
    {
        get { return _b; }
        set { _b = value; }
    }

    private double _c;

    public double c
    {
        get { return _c; }
        set { _c = value; }
    }

    private double _Delta;

    public double Delta
    {
        get { return _Delta; }
        //set { _Delta = value; }
    }

    private double _Raiz1;

    public double Raiz1
    {
        get { return _Raiz1; }
        //set { _Raiz1 = value; }
    }

    private double _Raiz2;

    public double Raiz2
    {
        get { return _Raiz2; }
        //set { _Raiz2 = value; }
    }

    private void CalculaDelta()                         //Privado pois só será usado dentro da classe
    {
        _Delta = Math.Pow(b,2) - 4 * _a * _c;
    }

    public bool CalculaRaízes()                           //Público
    {        
        CalculaDelta();                                  //Calcula o Delta

        if (TestaDelta())                               //Testa se é >=0
        {
            _Raiz1 = (-b + Math.Sqrt(_Delta)) / (2 * _a);
            _Raiz2 = (-b - Math.Sqrt(_Delta)) / (2 * _a);

            return true;
        }
        else
        {
           
            return false;
        }
    }

    private bool TestaDelta()                                //Privado pois só será usado dentro da classe
    {
        if (_Delta < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

class Program13
{
    static void Main(string[] args)
    {

        Eq2Grau Equação = new Eq2Grau();

        Console.Write("a = ");
        Equação.a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        Equação.b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        Equação.c = double.Parse(Console.ReadLine());

        if (Equação.CalculaRaízes())                              //Calcula as raízes
        {
            Console.WriteLine($"\nDelta = {Equação.Delta:F2}\n");

            Console.WriteLine($"Raiz 1 = {Equação.Raiz1:F2}");
            Console.WriteLine($"Raiz 2 = {Equação.Raiz2:F2}");
        }
        else
        {
            Console.WriteLine("\nNão existem raízes reais para a equação.");
        }

        Console.ReadKey();
    }
}
