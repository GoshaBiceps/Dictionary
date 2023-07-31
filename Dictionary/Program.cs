using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToWatchWords = "1";
            const string CommandTouseDictinary = "2";
            const string CommandToExit = "3";

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Корабль", "Большой");
            dictionary.Add("Машина", "Быстрая");
            dictionary.Add("Верблюд", "Горбатый");
            dictionary.Add("Кот", "Матроскаин");

            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine($"{CommandToWatchWords} - Просмотр ключевых слов\n{CommandTouseDictinary} - Узнать значение слов\n{CommandToExit} - Выход из программы");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandToWatchWords:
                        WritesWords(dictionary);
                        break;

                    case CommandTouseDictinary:
                        SearchValue(dictionary);
                        break;

                    case CommandToExit:
                        isWorking = false;
                        break;

                }
            }
        }

        static void WritesWords(Dictionary<string, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
        }

        static void SearchValue(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("В этом словаре, вы можете узнать значение слов");
            string userInput = Console.ReadLine();

            if (dictionary.ContainsKey(userInput))
            {
                Console.WriteLine(dictionary[userInput]);
            }
            else
            {
                Console.WriteLine("Такого слова в нашем словаре нет!");
            }
        }
    }
}
