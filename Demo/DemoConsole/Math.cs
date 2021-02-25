namespace DemoConsole
{
   public class Math
   {
      public int x { get; set; }
      public int y { get; set; }

      public Math(int x, int y)
      {
         this.x = x;
         this.y = y;
      }

      public int Add(int x, int y)
      {
         return x + y;
      }
   }
}
