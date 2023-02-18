using System;

namespace homework
{    class Program
    {
        static void Main()
        {
           Print("Введите трезначное число:");
           treeDigit(456);
        }
        public static void Print(string word){
            Console.WriteLine(word);
        }
          
        static void treeDigit (int numberA)
        {
            
            if(numberA > 99 && numberA < 1000)
              numberA = numberA / 10 % 10;
            Console.WriteLine(numberA);

        } 
            
        }

}

