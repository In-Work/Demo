using System;

namespace DemoConsole
{
   class Program
   {
      static void Main(string[] args)
      {
         int z = 3;

         Math math = new Math(z, 3);
         Console.WriteLine(math.Add(math.x, math.y));
      }
   }
}
