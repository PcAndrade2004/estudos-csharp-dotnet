Console.WriteLine("==== Tabuada ====\n");

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine()!);

int contador = 1;

while (contador < 11)
{
    int t = (n * contador);
    Console.WriteLine($"{n} x {contador} = {t}");
    contador++;
}

