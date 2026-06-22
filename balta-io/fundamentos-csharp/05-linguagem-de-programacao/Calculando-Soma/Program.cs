Console.WriteLine("Calculando soma de 1 a 50");

int soma = 0;
int contador = 1;

while (soma < 50)
{

    soma = soma += contador;

    if (soma < 50)
    {
        int subtrair = soma - 50;
        soma -= subtrair;
    }
    contador++;


}
Console.WriteLine(soma);




