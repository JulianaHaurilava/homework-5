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
        static string[] ToArray(string str)
        {
            return str.Split(' ');
        }

        /// <summary>
        /// Меняет порядок слов в предложении на обратный
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Предложение с обратным порядком слов</returns>
        static string ReverseSentence(string inputString)
        {
            string[] arrayOfWords = ToArray(inputString);
            Array.Reverse(arrayOfWords);
            return String.Join(' ', arrayOfWords);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputString = Console.ReadLine();

            Console.WriteLine(ReverseSentence(inputString));
        }
    }
}
