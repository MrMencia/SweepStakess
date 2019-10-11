using System;
namespace SweepStakesProject
{
    public class Contestant
    {
        public Contestant()
        {
        }

        //variables
            public string firstName;
            public string lastName;
            public int registrationNumber;
            public string emailAddress;
      
        
       



        // Constructor








        //Methods

        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string GetEmail()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }


        public int GenerateRegistrationNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            return number;
        }






    }
}

