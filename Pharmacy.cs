using System;

namespace Pharmacy
{
  class Pharmacy
  {
    public List<Patient> Patients { get; set; }
    

    public Pharmacy()
    {
      Patients = new List<Patient>();
    }

    public void CreatePatient()
    {
      var patient = new Patient();

      Console.WriteLine("Please enter the patient's information");
      Console.WriteLine();
      Console.WriteLine("Enter First name: ");
      patient.FirstName = Console.ReadLine();
      Console.WriteLine("Enter Last name: ");
      patient.LastName = Console.ReadLine();
      Console.WriteLine("Enter Date of birth: ");
      patient.DateOfBirth = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Enter Phone number ");
      patient.PhoneNumber = Console.ReadLine();
      Console.WriteLine("Enter Insurance name: ");
      patient.InsuranceName = Console.ReadLine();
      Console.WriteLine("Enter Member Id of Insurance: ");
      patient.MemberId = Console.ReadLine();
      Console.WriteLine("Enter the name of the new medication you would like to fill: ");
      patient.NameOfMedication = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("How many tablets would you like to fill for this new medication?");
      patient.tabletAmount = Console.ReadLine();

     
    }
    public void Refill1()
    {
      
      string NameOfMedication1;
      int patientAmountOfMedication;

      Console.WriteLine();
      Console.WriteLine("Enter the name of the medication you would like to refill: ");
      NameOfMedication1 = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("How many tablets would you like to refill for this medication?");
      Console.WriteLine();

      int.TryParse(Console.ReadLine(), out patientAmountOfMedication);
      

      if (patientAmountOfMedication <= 10)
      {
        Console.WriteLine();
        Console.WriteLine("You will need to request a new prescription in order to refill this medication.");
        Console.WriteLine();
    

      }
      else if (patientAmountOfMedication >= 10)
      {
        Console.WriteLine();
        Console.WriteLine("Your request has been sent. We will send you a text message when it is approved and ready for pick-up.");
        Console.WriteLine();
      }

      

    }

    public void Pharmacist()
    {
      Console.WriteLine();
      Console.WriteLine("Directing you to the UniPharm's Pharmacist now...");
      Console.WriteLine();
      
    }

    public void Exit()
    {
      Console.WriteLine();
      Console.WriteLine("Thank you. Have a nice day!");
      Console.WriteLine();
      Console.WriteLine("*****************************************************************************");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Main Menu below in case you forgot something.");
      Console.WriteLine();
      
      
    }

    
    
  }
    


}