using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomoweT3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctAnswer = false;
            Random random = new Random();
            var randomNumber = random.Next(1, 101);
            var numberOfTry = 0;
            Console.WriteLine("Wprowadz liczbe w zakresie od 0 - 100");
            while (!correctAnswer)
            {
                try
                {
                    var answerInput = int.Parse(Console.ReadLine());

                    if(answerInput > 100 || answerInput < 0)
                    {
                        Console.WriteLine("Wyszedles poza zakres!! (0 - 100)");
                    }
                    else if (answerInput > randomNumber)
                    {
                        Console.WriteLine("Za duzo!");
                        numberOfTry++;
                    }
                    else if (answerInput < randomNumber)
                    {
                        Console.WriteLine("Za malo");
                        numberOfTry++;
                    }
                    else if (answerInput == randomNumber)
                    {
                        correctAnswer = true;
                        Console.WriteLine("Trafiles!");
                        numberOfTry++;
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Blad! Zastosuj sie do polecenia");
                }
            }
            Console.WriteLine($"Podana liczba to {randomNumber}, zgadles za {numberOfTry} proba. ");
        }
    }
}
