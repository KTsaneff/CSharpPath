using System;
using System.Collections.Generic;
using System.Linq;

namespace _209.PokemonGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedValues = new List<int>(pokemons.Count);
            int sumOfRemovedElements = 0;
            int position;

            while (pokemons.Count > 0)
            {
                position = int.Parse(Console.ReadLine());
                

                if (position < 0)
                {
                    int positionValue = pokemons[0];
                    sumOfRemovedElements += pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    RecalculateValues(positionValue, pokemons);
                }
                else if (position > pokemons.Count - 1)
                {
                    int positionValue = pokemons[pokemons.Count - 1];
                    sumOfRemovedElements += pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    RecalculateValues(positionValue, pokemons);
                }
                else
                {
                    int positionValue = pokemons[position];
                    sumOfRemovedElements += positionValue;
                    pokemons.RemoveAt(position);
                    RecalculateValues(positionValue, pokemons);
                    
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        private static void RecalculateValues(int positionValue, List<int> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= positionValue)
                {
                    pokemons[i] += positionValue;
                }
                else
                {
                    pokemons[i] -= positionValue;
                }
            }
        }
    }
}
