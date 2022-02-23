using aleatorio;

List<int> lista = new List<int>();
List<int> lista2 = new List<int>();

lista= ListRandom.RandNoRepeat(6, 0, 4);

lista= ListRandom.RandNoRepeat(6, 0, 10);
Console.WriteLine("Lista 1: " + ListRandom.ConvertToString(lista));

lista2 = ListRandom.Combination(lista);
Console.WriteLine("Combinação: " + ListRandom.ConvertToString(lista2));

lista2 = ListRandom.Combination(lista);
Console.WriteLine("Combinação: " + ListRandom.ConvertToString(lista2));

lista2 = ListRandom.Combination(lista);
Console.WriteLine("Combinação: " + ListRandom.ConvertToString(lista2));
