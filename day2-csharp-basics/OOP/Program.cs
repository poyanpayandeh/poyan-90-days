// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program {
  
  static void Main (string [] args) {
    var user = new User("Poyan", "Auckland");
    Console.WriteLine("User Class call:");
    Console.WriteLine(user.Greet());
    Console.WriteLine();

    Console.WriteLine("Developer class call (Inherets User):");
    Developer Shaina = new Developer("Shaina", "Auckland");
    Shaina.addSkill("C++");
    Shaina.addSkill("Git");
    Shaina.addSkill("SQL");
    Shaina.PrintSummary();
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

class Developer : User {
  public List<string> skills {get; set;}

  public Developer(string name, string city) : base(name, city) {
    skills = new List<string>();
  }
  
  public void addSkill(string skill) => skills.Add(skill);

  public void PrintSummary() {
    Console.WriteLine(this.Greet());
    Console.WriteLine("And this is what I'm good at:");
    foreach (string skill in skills) {
      Console.WriteLine($"- {skill}");
    }
  }
}
