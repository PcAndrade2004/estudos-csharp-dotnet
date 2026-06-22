using Calculator;

internal class Program
{
    private static void Main(string[] args)
    {

        menu();

    }

    public static void menu()
    {
        Calculadora cal = new Calculadora();

        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Multiplicar");
        Console.WriteLine("3 - subtração");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Selecione uma Opção:");
        int opcao = int.Parse(Console.ReadLine()!);

        while (opcao != 5)
        {
            switch (opcao)
            {
                case 1:
                    cal.somar();
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    cal.multiplicacao();
                    Console.Clear();
                    menu();
                    break;
                case 3:
                    cal.subtracao();
                    Console.Clear();
                    menu();
                    break;
                case 4:
                    cal.divisao();
                    Console.Clear();
                    menu();
                    break;
                default:
                    menu();
                    break;

            }

        }
    }
}