using System;
using System.Collections.Generic;
using System.Linq;

namespace _206.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> packOne = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            List<int> packTwo = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            while (packOne.Count > 0 && packTwo.Count > 0)
            {
                int cardOne = packOne[0];
                int cardTwo = packTwo[0];

                if (cardOne > cardTwo)
                {
                    int playedCard = packOne[0];
                    packOne.RemoveAt(0);
                    packOne.Add(playedCard);
                    packOne.Add(packTwo[0]);
                    packTwo.RemoveAt(0);
                }
                else if(cardOne < cardTwo)
                {
                    int playedCard = packTwo[0];
                    packTwo.RemoveAt(0);
                    packTwo.Add(playedCard);
                    packTwo.Add(packOne[0]);
                    packOne.RemoveAt(0);
                }
                else if (cardOne == cardTwo)
                {
                    packOne.RemoveAt(0);
                    packTwo.RemoveAt(0);

                }
            }

            string winner = (packOne.Count > packTwo.Count) ? "First":"Second";


            Console.WriteLine($"{winner} player wins! Sum: {Math.Max(packOne.Sum(), packTwo.Sum())}");
        }
    }
}
