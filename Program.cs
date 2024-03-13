using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_13
// Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej)
// I będzie prostym kalkulatorem
//Podaj pierwszą liczbę: 
//…
//Podaj drugą liczbę:
//…
//Podaj numer operacji do wykonania:
//1. Dodawanie
//2. Odejmowanie
//3. Mnożenie
//4. Dzielenie
//…
//Twój wynik to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Jaką operację chcesz wykonać ? Wybierz numer: 1 - dodawanie ; 2 - odejmowanie; 3- dzielenie ; 4 - mnożenie :");
            int numer = Int32.Parse(Console.ReadLine());

            switch(numer)
            {
                case 1:
               
                    Console.WriteLine($"Wynik dodawania to: {a+b}");
                    break;
                case 2:
                    Console.WriteLine($"Wynik odejmowania to: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Wynik dzielenia to: {a % b}");
                    break;
                case 4:
                    Console.WriteLine($"Wynik mnożenia to: {a * b}");
                    break;
                default:
                    Console.WriteLine("Wybrano nieprawidłowy numer operacji");
                    break;

            }
            Console.ReadLine();






        }
    }
}
