using System;

namespace _104.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = ValidateLenght(password) &&
                            ValidateSyntax(password) &&
                            ValidateDigitCount(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateSyntax(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!ValidateDigitCount(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool ValidateDigitCount(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
                
                if (count >=2)
                {
                    return true;
                }
            }
           
            return false;
        }

        private static bool ValidateSyntax(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false; 
                }
            }

            return true;
        }

        private static bool ValidateLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
