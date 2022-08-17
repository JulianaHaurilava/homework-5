using System;
  

namespace task_5._1
{
    class Program
    {

        /// <summary>
        /// Создает из строки массив слов
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Массив из слов предложения</returns>
        static string[] ToArray(string inputString)
        {
            return inputString.Split(' ');
        }

        /// <summary>
        /// Выводит каждое слово предложения на отдельной строке
        /// </summary>
        /// <param name="arrayOfWords"></param>
        static void OneWordOneLinePrint(string[] arrayOfWords)
        {
            foreach (string word in arrayOfWords)
            {
                Console.WriteLine(word);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputString = Console.ReadLine();
            string[] arrayOfWords = ToArray(inputString);
            OneWordOneLinePrint(arrayOfWords);
        }
    }
}
