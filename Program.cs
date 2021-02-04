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
            */



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

        }
    }
}
