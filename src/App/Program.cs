using System;
using System.Threading;

namespace dotnet_artifacts {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      for (int i = 0; i < 100; i++) {
        Console.WriteLine($"i:{i}");
        Thread.Sleep(1000);
      }
    }
  }
}
