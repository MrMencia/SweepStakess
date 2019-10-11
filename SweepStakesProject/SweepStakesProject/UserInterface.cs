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

        internal static string AskManager()
        {
            throw new NotImplementedException();
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






        public static int ManageNumberOfContestants(string name)
        {
            int ContestantNumberChoice = 2;
            bool InfoIsCorrect = false;
            while (!InfoIsCorrect)
            {
                Console.WriteLine("How many contestants should there be for sweepstakes '" + name + "'? Type a positive integer between 2 and 10.");
                string choice = Console.ReadLine();
         

                if (int.TryParse(choice, out ContestantNumberChoice))
                    //Char.TryParse() is Char class method which is used to convert the value
                    //from given string to its equivalent Unicode character. Its performance
                    //is better than Char.Parse() method.
                {
                    if (ContestantNumberChoice >= 2 && ContestantNumberChoice <= 10)
                    {
                        InfoIsCorrect = true;
                        return ContestantNumberChoice;
                    }
                }
                else
                {
                    InfoIsCorrect = false;
                }
                Console.WriteLine("Please try again.");
            }
            return ContestantNumberChoice;
        }


        public int GenerateRegistrationNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 1000);
            return number;
        }


        public string RunSweepStakes(int maxNumberOfContestants)
        {
            for (int i = 1; i == maxNumberOfContestants; i++)
            {

                Contestant contestant = new Contestant();
                RegisterContestant(contestant);

                //contestant is the player inputting information which is also getting
                //registered

            }

            string winner = PickWinner();
            Console.WriteLine(winner);
            return winner;



        }

        private string PickWinner()
        {
            throw new NotImplementedException();
        }

        private void RegisterContestant(Contestant contestant)
        {
            throw new NotImplementedException();
        }
    }
}

