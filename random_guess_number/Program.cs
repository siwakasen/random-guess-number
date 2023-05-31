using System;
using System.Collections.Immutable;

namespace random_guess_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka_input;
            int angka_jawaban;
            int jml_input;
            String response;
            bool play = true;
            do
            {
                angka_input = -1;
                angka_jawaban=RandAngka();
                jml_input = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Total guesses : "+jml_input);
                    Console.Write("Input a number in range 1 to 100 : ");

                    while (!int.TryParse(Console.ReadLine(), out angka_input))
                    {
                        Console.WriteLine("It's not a number"); Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Total guesses : " + jml_input);
                        Console.Write("Input a number in range 1 to 100 : ");
                    }

                    if (angka_input < 0 || angka_input > 100) Console.WriteLine("Out of range !");
                    else if (angka_jawaban - angka_input < 3 && angka_input<angka_jawaban) Console.WriteLine("So close");
                    else if(angka_input - angka_jawaban < 3 && angka_input>angka_jawaban) Console.WriteLine("So close");
                    else if (angka_input < angka_jawaban) Console.WriteLine("It's lower");
                    else if (angka_input > angka_jawaban) Console.WriteLine("It's higher");

                    jml_input++;
                    if(jml_input < 10 && angka_input != angka_jawaban) Console.ReadKey ();
                } while (jml_input < 10 && angka_input!=angka_jawaban);

                if (angka_input == angka_jawaban) Console.WriteLine("You are right! It's " + angka_jawaban);
                else if(jml_input == 10) Console.WriteLine("You so bad, the correct number is "+ angka_jawaban);
                Console.Write("Wanna play again, master? (y/n) : "); response = Console.ReadLine();
                response = response.ToLower();
                if (response.Equals("y")) play = true;
                else play = false;
            } while (play);

            Console.WriteLine("\n\n\t[ Thanks for playing ^_^ ]");
            Console.WriteLine("\t[ Made by siwakasen a.k.a riksiprnm ]");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static int RandAngka()
        {
            Random random = new Random();
            return random.Next(1, 100) + 1; //it's gonna random an integer between 1 and 100
        }
    }
}
