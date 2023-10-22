using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_+-={}[]|\\:\";'<>?,./";

            Console.WriteLine("Please enter your password:");
            string userPassword = Console.ReadLine();
            int score = 0;

            if (userPassword.Length >= minLength)
            {
                score++;
            }

            if (ContainsCharacter(userPassword, uppercase))
            {
                score++;
            }

            if (ContainsCharacter(userPassword, lowercase))
            {
                score++;
            }

            if (ContainsCharacter(userPassword, digits))
            {
                score++;
            }

            if (ContainsCharacter(userPassword, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Password is extremely strong.");
                    break;
                case 3:
                    Console.WriteLine("Password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Password is weak.");
                    break;
                default:
                    Console.WriteLine("Password doesn't meet any of the standards.");
                    break;
            }
        }

      

        // ფუნქცია ამოწმებს შეიცავს თუ არა პაროლი ზემოთ აღნიშნულ სიმბოლოებს
        public static bool ContainsCharacter(string password, string characters)
        {
            foreach (char c in characters)
            {
                if (password.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
