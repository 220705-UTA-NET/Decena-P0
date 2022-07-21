using System;

namespace Pharmacy
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine();
      Console.WriteLine("Welcome to UniPharm Pharmacy!");

      var pharmacy = new Pharmacy();
      while(true)
      {
        int option;
        Console.WriteLine();
        Console.WriteLine("Please make a selection:  ");
        Console.WriteLine("1. Fill a New Prescription");
        Console.WriteLine("2. Refill Existing Medication");
        Console.WriteLine("3. Talk to the Pharmacist");
        Console.WriteLine("4. Exit");
        
        
        

        var input = int.TryParse(Console.ReadLine(), out option);

        Console.WriteLine("*****************************************************************************");

        switch (option)
        {
          case 1:
            pharmacy.CreatePatient();
            Console.WriteLine();
            Console.WriteLine("You request has been sent. We will send you a text message when it is approved and ready for pick-up.");
            Console.WriteLine();
            Console.WriteLine("Is there anything else I can help you with ?");
            Console.WriteLine();
            break;

          case 2:
            pharmacy.Refill1();
            Console.WriteLine();
            Console.WriteLine("Is there anything else I can help you with ?");
            Console.WriteLine();  
            break; 

          case 3:
            pharmacy.Pharmacist();
            Console.WriteLine();
            Console.WriteLine("Is there anything else I can help you with ?");
            Console.WriteLine();
            break;

          default:
            pharmacy.Exit();
            break;    

            
        }  
      }  

    }  
  }

}  