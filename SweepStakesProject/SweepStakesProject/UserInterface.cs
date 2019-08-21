using System;
namespace SweepStakesProject
{
    public class UserInterface
    {
        public UserInterface()
        {

        }
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
                int number = random.Next(1, 1000);
                return number;
            }










        }
    }
}
