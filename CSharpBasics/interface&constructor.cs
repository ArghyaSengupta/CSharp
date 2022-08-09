using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace InterfaceApplication {
   
   public interface ITransactions {
      // interface members
      //abstract methods : that don't have a body
      void showTransaction();/
      double getAmount();
   }
   public class Transaction : ITransactions 
   //class Transaction is implementing ITTransactions interface
   {
      private string tCode;
      private string date;
      private double amount;
      
      //constructor: same name as that of the class, no return type and init of variables
      //no arg constructir
      public Transaction() {
         tCode = " ";
         date = " ";
         amount = 0.0;
      }

      //Arg constructor
      //paramterized constructor: parameters
      public Transaction(string c, string d, double a) {
         tCode = c;
         date = d;
         amount = a;
      }

      //implementing abstract method1
      public double getAmount() {
         return amount;
      }

      //implementing abstract method2
      public void showTransaction() {
         Console.WriteLine("Transaction: {0}", tCode);
         Console.WriteLine("Date: {0}", date);
         Console.WriteLine("Amount: {0}", getAmount());
      }
   }
   class Tester {
     //passing values to the constructors
     
      static void Main(string[] args) {
         Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
         Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
         
         t1.showTransaction();
         t2.showTransaction();
         Console.ReadKey();
      }
   }
}