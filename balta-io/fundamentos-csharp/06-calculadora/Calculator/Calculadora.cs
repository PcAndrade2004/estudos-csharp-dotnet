using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace Calculator
{
    internal class Calculadora
    {
        // readLine -> Lê um item que escrevemos 
        public void somar()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());


            int somaTotal = numero1 + numero2;

            Console.WriteLine($"Resultado da Soma de {numero1} + {numero2} é: {somaTotal}");
            Console.ReadKey();

        }

        public void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo número: ");
            int v2 = int.Parse(Console.ReadLine()!);

            int valorTotal = v1 * v2;

            Console.WriteLine($"A multiplicação de {v1} x {v2} é {valorTotal}");
            Console.ReadKey();
        }

        public void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Informe o valor 1 : ");
            int valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine()!);

            int valorTotal = valor1 - valor2;

            Console.WriteLine($"A subtração de {valor1} - {valor2} é: {valorTotal}");
            Console.ReadKey();
        }

        public void divisao()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine()!);

            int valorTotal = valor1 / valor2;

            Console.WriteLine($"O resultado da subtração de {valor1} / {valor2} é: {valorTotal}");
            Console.ReadKey();
        }

    }
}
