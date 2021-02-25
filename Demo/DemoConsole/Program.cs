using System;

namespace DemoConsole
{
   class Program
   {
      static void Main(string[] args)
      {
         int z = 8;
         Math math = new Math(5, z);
         Console.WriteLine(math.Add(math.x, math.y));
      }
   }
}
