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
            Print("Введите число");
            
            int day;

            day = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 5)
            {
                Print("Нет");
            }
            if (day == 6 || day == 7)
            {
                Print("Да");
            }

        }
    }

}


