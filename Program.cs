using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)

    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Welcome to the Calculator App!");
      Console.WriteLine("What do you want to do?");
      Console.WriteLine("1. Add");
      Console.WriteLine("2. Subtract");
      Console.WriteLine("3. Multiply");
      Console.WriteLine("4. Divide");
      Console.WriteLine("5. Exit");
      Console.WriteLine("---------------------");
      Console.WriteLine("Please enter your choice: ");

      short choice = short.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          Add();
          break;
        case 2:
          Subtract();
          break;
        case 3:
          Multiply();
          break;
        case 4:
          Divide();
          break;
        case 5:
          Exit();
          break;
        default:
          Menu();
          break;
      }
    }

    static void Add()
    {
      Console.Clear();
      Console.WriteLine("Please enter the first number: ");

      string firstNumber = Console.ReadLine();
      float firstNumberfloat = float.Parse(firstNumber);

      Console.WriteLine("Please enter the second number: ");

      string secondNumber = Console.ReadLine();
      float secondNumberfloat = float.Parse(secondNumber);

      float result = firstNumberfloat + secondNumberfloat;
      Console.WriteLine("The result is: " + result);
    }

    static void Subtract()
    {
      Console.Clear();
      Console.WriteLine("Please enter the first number: ");

      string firstNumber = Console.ReadLine();
      float firstNumberfloat = float.Parse(firstNumber);

      Console.WriteLine("Please enter the second number: ");

      string secondNumber = Console.ReadLine();
      float secondNumberfloat = float.Parse(secondNumber);

      float result = firstNumberfloat - secondNumberfloat;
      Console.WriteLine("The result is: " + result);
    }

    static void Multiply()
    {
      Console.Clear();
      Console.WriteLine("Please enter the first number: ");

      string firstNumber = Console.ReadLine();
      float firstNumberfloat = float.Parse(firstNumber);

      Console.WriteLine("Please enter the second number: ");

      string secondNumber = Console.ReadLine();
      float secondNumberfloat = float.Parse(secondNumber);

      float result = firstNumberfloat * secondNumberfloat;
      Console.WriteLine("The result is: " + result);
    }


    static void Divide()
    {
      Console.Clear();
      Console.WriteLine("Please enter the first number: ");

      string firstNumber = Console.ReadLine();
      float firstNumberfloat = float.Parse(firstNumber);

      Console.WriteLine("Please enter the second number: ");

      string secondNumber = Console.ReadLine();
      float secondNumberfloat = float.Parse(secondNumber);

      float result = firstNumberfloat / secondNumberfloat;
      Console.WriteLine("The result is: " + result);
    }

    static void Exit()
    {
      Console.Clear();
      Console.WriteLine("Thank you for using the Calculator App!");
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
      System.Environment.Exit(0);
    }

  }

}
