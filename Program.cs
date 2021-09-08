using System;

namespace RPS
{
  class Program
  {

    static void Main(string[] args)
    {
      string[] compChoice = {"rock", "paper", "scissors"};
      Random random = new Random();
      int computer = random.Next(0, compChoice.Length);

      Console.Clear();
      //   Console.ResetColor();
      Console.WriteLine("What's your name?");
      
      string name = Console.ReadLine();
            Console.Beep();

      Console.ForegroundColor = ConsoleColor.DarkCyan;
      System.Console.WriteLine($"Hi {name}! Want to play rock, paper, scissors? (y/n)");
      Console.Beep();Console.Beep();

      
      var answer = Console.ReadKey().KeyChar;
      if(answer == 'n'){
        System.Console.WriteLine("\n Have a great day without me!");
      }
      else
      {
          
      System.Console.WriteLine("\n Let's play!");
      Console.Clear();
      System.Console.WriteLine("Choose Rock, Paper, Scissors:");
        string choice = Console.ReadLine().ToLower();

        
        if(choice != "rock" && choice != "paper" && choice != "scissors" ){
            System.Console.WriteLine("that doesn't exist. Try again!");

        }else{
        
        System.Console.WriteLine("You chose " + choice + ". The computer chose " + computer);

        if(choice == "rock" && computer == 0){
            System.Console.WriteLine("You tied");
          }
        if(choice == "rock" && computer == 1){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You lost!");
            Console.Beep();
        }
        if(choice == "rock" && computer == 2){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Congratulations, You won!");
      Console.Beep();
      Console.Beep();

        }
        if(choice == "paper" && computer == 0){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Congratulations, You won!");
                  Console.Beep();
      Console.Beep();

          }
        if(choice == "paper" && computer == 1){
            System.Console.WriteLine("You tied!");
        }
        if(choice == "paper" && computer == 2){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You lost!");
            Console.Beep();
        }
        if(choice == "scissors" && computer == 0){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You lost!");
            Console.Beep();
          }
        if(choice == "scissors" && computer == 1){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Congratulations, You won!");
                  Console.Beep();

        }
        if(choice == "scissors" && computer == 2){
            System.Console.WriteLine("You tied!");
        }
        
        }

      }
           Console.ResetColor();
    }
  }
}
