using System;

namespace homework
{
    class Program
    {
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }
        static void Main()
        {
            Print("Вывести третью цифру заданного числа или сообщить, что третьей цифры нет.");
            Print("Введите число:");


            twoDigit(78);
            static void twoDigit(int numberX)
            {
                if (numberX < 100)
                    Console.WriteLine("Третьей цифры нет");
            }


            treeDigit(645);
            static void treeDigit(int numberX)
            {
                if (numberX < 1000 && numberX > 100)
                    numberX = numberX % 10;
                Console.WriteLine(numberX);
            }

            fourDigit(5783);
            static void fourDigit(int numberX)
            {
                if (numberX > 1000)
                    numberX = numberX / 10 % 10;
                Console.WriteLine(numberX);
            }


            fiveDigit(32679);
            static void fiveDigit(int numberX)
            {
                if (numberX > 10000)
                    numberX = numberX / 100 % 10;
                Console.WriteLine(numberX);
            }

        }

    }

}

