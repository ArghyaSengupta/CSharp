using System;

namespace PolymorphismApplication {
   class Printdata {
      void print(int i) // integer values
       {
         Console.WriteLine("Printing int: {0}", i );
      }
      void print(double f)// double values 
      {
         Console.WriteLine("Printing float: {0}" , f);
      }
      void print(string s)// string values 
      {
         Console.WriteLine("Printing string: {0}", s);
      }
      static void Main(string[] args) {
         Printdata p = new Printdata();
         
         // Call print to print integer
         p.print(5);// compile time polymorphism
         
         // Call print to print float
         p.print(500.263);
         
         // Call print to print string
         p.print("Hello C++");
         Console.ReadKey();
      }
   }
}