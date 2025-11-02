// See https://aka.ms/new-console-template for more information
// Outline:
// Method parameters
// Return Values 
// Static vs inference
// Input Validation

class Program {
  static void Main(string[] args) {
    int numberOfStudents = GetNumberOfStudents();
    List<Student> students = new List<Student>();
    
    for (int i = 1; i <= numberOfStudents; i++) {
      Console.WriteLine($"Student #{i}'s name: ");
      string input = Console.ReadLine();
      string name = input;
      Console.WriteLine($"Students name : {name}");
      input = "";

      Console.WriteLine("1st score: ");
      double score1 = getScore();
      Console.WriteLine("2nd score: ");
      double score2 = getScore();
      Console.WriteLine("3rd score: ");
      double score3 = getScore();
      
      Student student = new Student(name, score1, score2, score3);
      students.Add(student);
    }

    foreach (Student student in students) {
      student.print();
    }
  }
  
  // Methods 
  static int GetNumberOfStudents() {
    int numberOfStudents = 0;
    string input = "";
    
    do {
      Console.Write("Please enter the amount of students (value must be a postive number greater than 0): ");
      input = Console.ReadLine();

      if (int.TryParse(input, out numberOfStudents)) {
        return numberOfStudents;
      } else {
        Console.WriteLine("Failed: Please enter a NUMBER greater than 0");
      }
    } while (numberOfStudents <= 0);

    return 0;
  }

  static double getScore() {
    string input = "";
    double score = 0;

    do {
      input = Console.ReadLine();
      if(double.TryParse(input, out score)) {
        if (score <= 0) {

        } else {
          return score;
        }
      } 
    } while (score <= 0);

    return 0;
  }
}

class Student {
  string name {get; set;}
  double score1 {get; set;}
  double score2 {get; set;}
  double score3 {get; set;}

  public Student(string name, double score1, double score2, double score3) {
    this.name = name;
    this.score1 = score1;
    this.score2 = score2;
    this.score3 = score3;
  } 
  
  private double getLowestScore() {
    double lowest = score1;
    if (lowest <= score2 && lowest <= score3) {
      return lowest;
    }

    lowest = score2;
    if (lowest <= score1 && lowest <= score3) {
      return lowest;
    } 
    

    lowest = score3;
    if (lowest <= score1 && lowest <= score2) {
      return lowest;
    }

    return 0;
  }


  private double getHighestScore() {
    double highest = score1;
    if (highest >= score2 && highest >= score3) {
      return highest;
    }

    highest = score2;
    if (highest >= score1 && highest >= score3) {
      return highest;
    } 
    

    highest = score3;
    if (highest >= score1 && highest >= score2) {
      return highest;
    }

    return 0;
  }

  private double calculateAverage() {
    double sum = (score1 +  score2 + score3);
    return sum / 3;
  }

  public void print(){
    Console.WriteLine($"{name}, {score1},{score2},{score3}");
    Console.WriteLine($"Lowest: {getLowestScore()}");
    Console.WriteLine($"Highest: {getHighestScore()}");
    Console.WriteLine($"Average: {Math.Round(calculateAverage(), 2)}");
  }
}
