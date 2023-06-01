class Eq2Grau                           //Classe para trabalhar com uma Equação do 2º grau
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
        //set { _Delta = value; }                   //Usuário não terá acesso para alterar o valor de Delta
    }

    private double _Raiz1;

    public double Raiz1
    {
        get { return _Raiz1; }
        //set { _Raiz1 = value; }                   //Usuário não terá acesso para alterar o valor de Raiz1
    }

    private double _Raiz2;

    public double Raiz2
    {
        get { return _Raiz2; }
        //set { _Raiz2 = value; }                   //Usuário não terá acesso para alterar o valor de Raiz2
    }

    public void CalcDelta()
    {
        _Delta = Math.Pow(b,2) - 4 * a * c;
    }

    public void CalcRaízes()
    {
        _Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
        _Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);
    }
}

class Program11
{
    static void Main(string[] args)
    {
        Eq2Grau Equação = new Eq2Grau();

        Console.Write("a =  ");
        Equação.a = double.Parse(Console.ReadLine());

        Console.Write("b =  ");
        Equação.b = double.Parse(Console.ReadLine());

        Console.Write("c =  ");
        Equação.c = double.Parse(Console.ReadLine());

        Equação.CalcDelta();                          // Calcula o delta

        Console.WriteLine($"\nDelta = {Equação.Delta:F2}\n");

        if (Equação.Delta >= 0)
        {
            Equação.CalcRaízes();                     // Calcula as raízes

            Console.WriteLine($"Raiz 1 = {Equação.Raiz1:F2}");
            Console.WriteLine($"Raiz 2 = {Equação.Raiz2:F2}");
        } else
        {
            Console.WriteLine("A equação não possui raízes reais.");
        }

        Console.ReadKey();
    }
}