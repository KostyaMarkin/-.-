using System;
using System.Text;
using System.IO;

namespace Экзамен._Чтение_из_файла
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какого автора вам нужно найти?");
            string athor = Console.ReadLine();
            string[] BooksInformation = File.ReadAllLines("Books.txt");
            for (int i = 0; i < BooksInformation.Length;i++ )
            {
                string[] OneBooks = BooksInformation[i].Split(',');
                if (int.Parse(OneBooks[2]) > 1600 && OneBooks[0] == athor)
                    Console.WriteLine(BooksInformation[i]);
            }
            Console.ReadKey();
        }
    }
}
