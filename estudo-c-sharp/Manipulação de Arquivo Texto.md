Fundamentos para ``Criar`` , ``gerenciar caminhos``, ``Salvar`` e ``Ler`` dados em arquivos de texto.

## O que é *var path* (Caminho do Arquivo)
O path (caminho) ;e uma varável do tipo string que indica ao sistema operacional aonde o arquivo deve ser criado ou lido.

* Prefixado com @ (Verbatim String):  Permite usar barras invertidas \ normais do Windows sem que o C# ache que é caminho especial.
* Caminho Absoluto : Aponta para um local exato do disco (Ex: `@"C:\Projetos\dados.txt"`).

##  Escrevendo em Arquivos 
Temos que importar a classe ``System.IO.File`` fornece os métodos mais rápidos para gravar informações no disco.
- **`File.WriteAllText(path, texto);`**
    - **O que faz:** Cria um arquivo novo. Se o arquivo já existir, apaga tudo o que estava dentro e escreve o novo texto por cima (sobrescreve). 
- **`File.AppendAllText(path, texto);`**
    - **O que faz:** Adiciona o texto ao final do arquivo existente sem apagar o conteúdo anterior. Se o arquivo não existir, cria um novo

## Lendo Arquivo (Abrir e Exibir Dados)
Ler ou Abrir um arquivo de texto temos algumas abordagens

### Opção A: Lendo tudo de uma vez (File.ReadAllText)
```C# 
string conteudo = File.ReadAllText(path);
Console.WriteLine(conteudo);
```

### Opção B: Ler linha por linha em um Array (File.ReadAllLines)
* Divide o arquivo e coloca cada linha em uma posição de um Array de string usamos com laço *foreach*
```C#
string[] linhas = File.ReadAllLines(path);
foreach (string linha int linhas) {
	Console.WriteLine("Linha lida: " + linha);
}
```

## Using declaration

### Forma Moderna - Using declaration
O arquivo fecha sozinho quando o método atual chegar ao fim.
```C#

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
```

* #StreamWrite => usamos quando queremos abrir um arquivo.
* #StreamReader => Usamos quando precisamos ler um arquivo.

### Using Tradicional
O arquivo fica aberto apenas dentro da **{ }** 
```C# 
var path = @"C:\teste\teste.txt";

using (StreamReader file = new StreamReader(path)) {
	string texto = file.ReadToEnd();
	Console.WriteLine(texto);
}
```


**

## Código Exemplo Prático de Revisão


```C#
using System;  
using System.IO; // Obrigatório para manipular arquivos  
  
class Program  
{  
    static void Main()  
    {  
        string path = @"C:\EstudosCS\meu_arquivo.txt";  
  
        // 1. Garante que a pasta existe antes de mexer no arquivo  
        Directory.CreateDirectory(Path.GetDirectoryName(path));  
  
        // 2. Escreve o texto inicial  
        File.WriteAllText(path, "Primeira linha do meu arquivo.\n");  
  
        // 3. Adiciona mais texto usando StreamWriter e using  
        using (StreamWriter writer = File.AppendText(path))  
        {  
            writer.WriteLine("Segunda linha adicionada com segurança.");  
        }  
  
        // 4. Regra de ouro: Sempre verifique se o arquivo existe antes de tentar ler  
        if (File.Exists(path))  
        {  
            Console.WriteLine("--- LENDO O ARQUIVO ---");  
             
            // Abre e lê todo o conteúdo do arquivo  
            string conteudoTotal = File.ReadAllText(path);  
            Console.WriteLine(conteudoTotal);  
        }  
        else  
        {  
            Console.WriteLine("O arquivo não foi encontrado!");  
        }  
    }  
}  
```

