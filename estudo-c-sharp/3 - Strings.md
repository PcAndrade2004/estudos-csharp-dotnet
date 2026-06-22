## GUID 
GUID (**Globally Unique Identifier**) é um identificador único global de 128 bits

GUID usa uma estrutura de **32 dígitos**.

Exemplo: 
```C# 
550e8400-e29b-41d4-a716-446655440000
```

### Criando um #GUID

```c# 
Guid id = Guid.NewGuid();
```
* Gera um identificador único.

### Convertendo String para GUID 

```C# 

string texto Valido = "123e4567-e89b-12d3-a456-426655440000"; 

Guid id = Guid.Parse(textoValido);
```

#### Conversão Segura 
```C#
string texto Valido = "123e4567-e89b-12d3-a456-426655440000"; 

Guid.TryParse(texto, out Guid id);
```

## Formatação de Exibição 
### Padrão

```C#
id.ToString()
```

```C#
550e8400-e29b-41d4-a716-446655440000
```

### Sem hífens

```C#
id.ToString("N")
```

```C#
550e8400e29b41d4a716446655440000
```

### Com chaves

```C#
id.ToString("B")
```

```C#
{550e8400-e29b-41d4-a716-446655440000}
```

## Quando usar `int` ou `Guid`?

### Use `int`

```c#
public int Id { get; set; }
```

Quando:

- Projetos simples
- Sistemas acadêmicos
- CRUD básico

### Use `Guid`

```c#
public Guid Id { get; set; }
```

Quando:

- APIs REST
- Microsserviços
- Sistemas distribuídos
- Integrações entre sistemas