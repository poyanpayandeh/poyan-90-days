// See https://aka.ms/new-console-template for more information
List<int> list = new List<int>();

for (int i = 1; i <= 10; i++){
  list.Add(i);
}

Console.WriteLine($"Min {list.Min()}");
Console.WriteLine($"Max: {list.Max()}");
Console.WriteLine($"Average: {list.Average()}");
