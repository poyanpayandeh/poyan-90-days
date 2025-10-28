// See https://aka.ms/new-console-template for more information
using System;

class Program {
 
static void Main(string[] args) {
  for (int i = 0; i <= 100; i++) {
      if(i % 3 == 0){
        Console.Write("Fizz");
      }

      if (i % 5 == 0){
        Console.Write("Buzz");
      }
      
      if (i % 3 != 0 && i % 5 != 0){
        Console.Write(i);
      }

      Console.Write("\n");
    }
  }
}



