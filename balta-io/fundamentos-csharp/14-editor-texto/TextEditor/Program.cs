

using System.Data;
using System.IO;

Menu();

static void Menu()
{
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 -Abrir arquivo");
    Console.WriteLine("2 -Criar arquivo");
    Console.WriteLine("0 -Sair");
    short opcao = short.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Abrir();
            break;
        case 2:
            editar();
            break;
    }
}

static void Abrir()
{
    Console.WriteLine("Qual caminho do arquivo? ");
    string path = Console.ReadLine()!;

    using (var file = new StreamReader(path)) {
        string texto = file.ReadToEnd();
        Console.WriteLine(texto);
    }

    Console.WriteLine("");
    Console.ReadKey();
    Menu();
}
static void editar()
{
    Console.WriteLine("Digite o seu texto abaixo: (ESC para sair do editot)");

    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

static void Salvar(string text)
{
    //Console.Clear();
    //Console.WriteLine("Qual caminho para salvar o arquivo?");

    //var digito = Console.ReadLine();
    var path = @"C:\teste\teste.txt";

    // devemos usar o using (quando formos abrir um arquivo) para fechar automaticamente
    // Ler arquivo => (StreamReader)
    //Abrir arquivo => (StreamWrite)

    using (var file = new StreamWriter(path))   
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Menu();
    
}