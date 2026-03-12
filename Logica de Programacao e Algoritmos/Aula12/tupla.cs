//tupla

var clodoaldo = (34, 5000.34, "Heitor", "SENAI", 'B');

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");
System.Console.WriteLine($"Nome do filho do clodoaldo: {clodoaldo.Item3}");
clodoaldo.Item1 = 54;
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");