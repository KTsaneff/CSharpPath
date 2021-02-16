using System;

namespace _401.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            bool isUnlocked = false;
            int battleCount = 0;

            for (int i = 1; i <= battlesCount; i++)
            {
                battleCount = i;
                double currExperience = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    currExperience *= 1.15;
                    neededExperience -= currExperience;
                }
                else if (i % 5 == 0 && i % 15 != 0)
                {
                    currExperience *= 0.9;
                    neededExperience -= currExperience;

                }
                else if (i % 15 == 0)
                {
                    currExperience *= 1.05;
                    neededExperience -= currExperience;

                }
                else
                {
                    neededExperience -= currExperience;
                }

                if (neededExperience <= 0)
                {
                    isUnlocked = true;
                    break;
                }
            }

            if (isUnlocked)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }
        }
    }
}
