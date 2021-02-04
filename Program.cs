using System;

namespace zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string A;
              string B;
              string C = A!= B;
            

            int A;
            int B;
            double X;
            double Y;
            bool C = (A < B) | (X > Y);
            

            var inv = true;
            var result = !inv;
            Console.WriteLine(result);
            Console.ReadKey();
           



            Console.WriteLine("Введите свой любимвый цвет на английском и с маленькой буквы");
            var color = Console.ReadLine();

            if (color == "red")
                {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");

                }
            else if (color == "green")
                {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                }
            else
                {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                 }

            Console.ReadKey();
            
            Console.WriteLine("Введите свой любимвый цвет на английском и с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            Console.ReadKey();

             */

            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 3);





        }
    }
}
