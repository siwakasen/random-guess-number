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
                //here is the init
                angka_input = -1;         
                angka_jawaban=RandAngka();
                jml_input = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Total guesses : " + jml_input);
                    Console.Write("Input a number in range 1 to 100 : ");

                    while (!int.TryParse(Console.ReadLine(), out angka_input)) //this loop is for checking if the input is a proper number
                    {
                        Console.WriteLine("It's not a number"); Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Total guesses : " + jml_input);
                        Console.Write("Input a number in range 1 to 100 : ");
                    }

                    //all code down here is to checking input to the right answer
                    if (angka_input < 0 || angka_input > 100) Console.WriteLine("Out of range !");
                    else if (angka_jawaban - angka_input < 3 && angka_input < angka_jawaban) Console.WriteLine("So close");
                    else if (angka_input - angka_jawaban < 3 && angka_input > angka_jawaban) Console.WriteLine("So close");
                    else if (angka_input < angka_jawaban) Console.WriteLine("It's lower");
                    else if (angka_input > angka_jawaban) Console.WriteLine("It's higher");

                    jml_input++;
                    if (jml_input < 10 && angka_input != angka_jawaban) Console.ReadKey();

                } while (jml_input < 10 && angka_input != angka_jawaban);

                if (angka_input == angka_jawaban) Console.WriteLine("You are right! It's " + angka_jawaban);     //win lose condition
                else if(jml_input == 10) Console.WriteLine("You so bad, the correct number is "+ angka_jawaban);

                Console.Write("Wanna play again, master? (y/n) : "); response = Console.ReadLine();
                response = response.ToLower();
                if (response.Equals("y")) play = true;
                else play = false;

            } while (play); //if play is true, then we back to do above and doing init again

            Console.WriteLine("\n\n\t[ Thanks for playing ^_^ ]");
            Console.WriteLine("\t[ Made by siwakasen a.k.a riksiprnm ]");

            Console.ForegroundColor = ConsoleColor.Black; //this is used for making the end of console message to unseen
        }
        static int RandAngka()
        {
            Random random = new Random();
            return random.Next(1, 100) + 1; //it's gonna random an integer between 1 and 100
        }
    }
}
