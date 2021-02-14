using System;
using System.Linq;

namespace _101.EncrSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arrOfInputs = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int sumElements = 0;
                char[] inputToLetters = input.ToCharArray();
                int[] lettersToNum = new int[inputToLetters.Length];

                for (int j = 0; j < lettersToNum.Length; j++)
                {
                    if (inputToLetters[j] == 'a' || inputToLetters[j] == 'A' || inputToLetters[j] == 'e' || inputToLetters[j] == 'E' || inputToLetters[j] == 'i' || inputToLetters[j] == 'I' || inputToLetters[j] == 'o' || inputToLetters[j] == 'O' || inputToLetters[j] == 'u' || inputToLetters[j] == 'U')
                    {
                        lettersToNum[j] = (int)inputToLetters[j] * lettersToNum.Length;
                    }
                    else
                    {
                        lettersToNum[j] = (int)inputToLetters[j] / lettersToNum.Length;
                    }
                }

                foreach (var element in lettersToNum)
                {
                    sumElements += element;
                }

                arrOfInputs[i] = sumElements;
            }

            for (int i = 0; i < arrOfInputs.Length; i++)
            {
                for (int j = i + 1; j < arrOfInputs.Length; j++)
                {
                    if (arrOfInputs[i] > arrOfInputs[j])
                    {
                        int temp = arrOfInputs[i];
                        arrOfInputs[i] = arrOfInputs[j];
                        arrOfInputs[j] = temp;
                    }
                }
            }

            foreach (var element in arrOfInputs)
            {
                Console.WriteLine(element);
            }
        }
    }
}
