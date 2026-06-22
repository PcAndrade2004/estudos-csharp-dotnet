Console.WriteLine("==== Exibindo número de 1 a 100 ====\n");

int contadorPares = 0;
int numero = 1;

while(numero < 101)
{
    if (numero % 2 == 0)
    {
        contadorPares++;
    }

    numero++;

}

Console.WriteLine(contadorPares);
