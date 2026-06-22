

using System.Diagnostics;
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundos => 10S");
    Console.WriteLine("M = Minutos => 10M");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quando tempo deseja contar? ");

    string data = Console.ReadLine()!.ToLower(); // To.Lower => converte tudo para minusculo

    char tipo = char.Parse(data.Substring(data.Length - 1, 1)); // usando char.Parse() => para converter. Data.Lenght => verifica quantos caracteres usuário digitou
    int time = int.Parse(data.Substring(0, data.Length -1));
    int multiplier = 1;

    if(tipo == 'M')
    {
        multiplier = 60;
    }
    if(time == 0)
    {
        System.Environment.Exit(0);
    }

    Start(time * multiplier);

    
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();

    Console.WriteLine("Stopwatch finalizado...");
    Thread.Sleep(2500);
    Menu();
}


