## Interpolação de String
A interpolação de String em C# é uma forma mais simples e legível de inserir valores de variáveis.

## Sintaxe Básica 
Basta colocarmos o caractere ``$`` antes da String e envolver a variável entre ``{}`` 
```C#
String nome = "Paulo";
int idade = 21;

Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

SAÍDA
// Meu nome é Paulo e tenho 21 anos
```

## Podemos usar expressões 
```C# 
int a = 10;
int b = 10;

Console.WriteLine($"A soma e {a} + {b}");

SÁÍDA 
// A soma é 30
```

