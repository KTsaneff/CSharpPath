using System;
using System.Collections.Generic;
using System.Linq;

namespace _402.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> particles = Console.ReadLine().Split("|").ToList();
            string command;

            int limit = 0;
            if (particles.Count % 2 == 0)
            {
                limit = particles.Count / 2;
            }
            else
            {
                limit = particles.Count / 2 + 1;
            }

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArg = command.Split();
                string action = cmdArg[0];
                string direction = cmdArg[1];
                
                if (action == "Move")
                {
                    int index = int.Parse(cmdArg[2]);

                    if (direction == "Left")
                    {
                        if (index - 1 >= 0 && index < particles.Count)
                        {
                            string temp = particles[index-1];
                            particles[index - 1] = particles[index];
                            particles[index] = temp;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (direction == "Right")
                    {
                        if (index >= 0 && index + 1 <particles.Count)
                        {
                            string temp = particles[index + 1];
                            particles[index + 1] = particles[index];
                            particles[index] = temp;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                
                if (action == "Check")
                {
                    string[] printOut =new string[limit];

                    if (direction == "Even")
                    {
                        int counter = 0;
                        for (int i = 0; i < particles.Count; i+=2)
                        {
                            printOut[counter] = particles[i];
                            counter++;
                        }
                    }
                    else if (direction == "Odd")
                    {
                        int counter = 0;
                        for (int i = 1; i < particles.Count; i+=2)
                        {
                            printOut[counter] = particles[i];
                            counter++;
                        }
                    }

                    Console.WriteLine(string.Join(" ", printOut));
                }
            }

            Console.WriteLine($"You crafted {string.Join("", particles)}!");
        }
    }
}
