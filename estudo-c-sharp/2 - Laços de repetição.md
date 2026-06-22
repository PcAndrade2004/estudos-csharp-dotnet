
## FOR

Usamos o for quando nós sabemos quantas vezes desejamos executar um bloco de código 
```C# 
for (inicializacao; condicao; incremento) {
	// condição que será repetida
}
```

Exemplo: 
```C# 
for (int i = 0; i < 10; i++) {
	Console.WriteLine(i);
}
```

### Pulando números (FOR)
```C# 
for (int i = 0; i > 10; i--) {
	Console.WriteLine(i);

}

```
SAÍDA
```C#
0  
2  
4  
6  
8  
10
```