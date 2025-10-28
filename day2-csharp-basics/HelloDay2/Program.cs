// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program {
  
  // Entry point (sync)
  static async Task Main (string [] args) {
    Console.WriteLine("Day 2 - C# Fundamentals\n");

    // 1) Variables, types, interpolation
    int age = 28;
    string name = "Poyan";
    double weight = 82.5;
    Console.WriteLine($"Hi {name}, age {age},weight {weight}");

    // 2) Arrays & Loops
    string[] langs = {"C#", "Javascipt", "SQL"};
    foreach (string language in langs) {
      Console.WriteLine($"Lang: {language}");
    }

    // 3) Methods
    Console.WriteLine($"Add(2,3) = {Add(2,3)}");
    
    // 4) Objects & Classes
    var user = new User("Poyan", "Auckland");
    Console.WriteLine(user.Greet());
    // 5) Async/await (true concurrency require I/O)
    await PretendHttpCallAsync();

    // 6 Null- Safety
    string? maybe = null;
    Console.WriteLine($"Maybe is null? {maybe is null}");
  }

  static int Add(int a, int b) => a + b;

  static async Task PretendHttpCallAsync() {
    Console.WriteLine("\nStarting async work...");
    await Task.Delay(500);
    Console.WriteLine("Async work done.");
  }
}

class User {
  public string Name { get; }
  public string City { get; private set;}

  public User(string name, string city) {
    Name = name;
    City = city;
  }

  public string Greet() => $"Hello, I'm {Name} from {City}";
}
