using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _303.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|"); //Взимаме входа като масив

            string firstPart = input[0]; //взимаме първата част от входа,  като нулев индекс от масива
            string secPart = input[1]; // взимаме втората част от входа, като индекс 1
            string thirdPart = input[2]; // взимаме третата част от входа, като индекс 2

            string firstPattern = @"([#$%&*])([A-Z]+)(\1)"; //създаваме шаблон за да извлечем главните букви заедно с ограждащите ги символи
            Match firstMatch = Regex.Match(firstPart, firstPattern); //извличаме съвпадение от първата част на входа по създадения шаблон
            string capitals = firstMatch.Groups[2].Value; //извличаме само главните букви от група 2 на съвпадението, като string

            for (int i = 0; i < capitals.Length; i++) //итерираме по всяка една буква от така извлечения string
            {
                char initialLetter = capitals[i]; //взимаме си char, символ от string-а с индекс i, този char е  съответната главна буква
                int asciiCode = initialLetter; //int взима стойност ascii стойността на char-а

                string secPattern = $@"{asciiCode}:(?<length>[0-9][0-9])"; //създаваме шаблон {ascii кода на char-а}:{още две други числа[0-9]}
                Match secMatch = Regex.Match(secPart, secPattern); // извличаме съвпадение {аски номера на буквата}:{добавъчната дължина на думата}
                int wordLength = int.Parse(secMatch.Groups["length"].Value); //int взима стойност на втората двойка числа от въпадението, която сме кръстили "length"

                string thirdPattern = $@"(?<=\s|^){initialLetter}[^\s\.(?=\s|$)]{{{wordLength}}}\b"; //шаблон за дума със зададена главна буква и нейната доб.дължина
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern); //извличаме съвпадение за нужната дума, започваща с моментната буква и имаща дължина моментната добавъчна дължина

                string word = thirdMatch.ToString();
                Console.WriteLine(word);
            }
        }
    }
}
