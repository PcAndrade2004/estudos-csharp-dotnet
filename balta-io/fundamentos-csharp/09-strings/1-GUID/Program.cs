Console.WriteLine("==== GUID ====\n");

// Em diversos momentos precisamos identificar alguem seja com (id) ou os (GUIDS)

var ID = Guid.NewGuid();
Console.WriteLine(ID);

Console.WriteLine($"Guid Padrão:  {ID.ToString("N")}");

Console.WriteLine($"Guid Sem Hífens:  {ID.ToString("N")}");

Console.WriteLine($"Guid com Chaves:  {ID.ToString("B")}");

string texto = "dsadasdasd11221eqwd12";

Guid id = Guid.Parse(texto);

Console.WriteLine(id);




