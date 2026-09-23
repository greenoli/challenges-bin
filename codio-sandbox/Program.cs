// codio-sandbox/Program.cs

// it's more common in earlier versions of .NET (.NET 5 and earlier) to have
// all this namespace guff

// see https://aka.ms/new-console-template for more info

using System;

namespace MyApp
{
  public class Program
  {
    static void Main(string[] args)
    {
      int my_first_int = 60;
      int my_second_int = 9;

      // Oh yeah, it's all coming together
      int my_third_int = my_first_int + my_second_int;
      Console.WriteLine(my_third_int);
      }
  }
}

// RUN 'dotnet run' FROM WITHIN THE PROJECT FOLDER ('hello-world') TO RUN THIS FILE