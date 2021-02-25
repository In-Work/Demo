using System;

namespace DemoConsole
{
   class Program
   {
      static void Main(string[] args)
      {
         Math math = new Math(5, 3);
         Console.WriteLine(math.Add(math.x, math.y));
      }
   }
}
