using System;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Podaj a, b, c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("A jest równe 0! Nie można dzielić przez 0!");
        }
        else if (delta == 0)
        {
            double x0 = -b / 2 * a;
            Console.WriteLine("Delta z jednym miejscem zerowym wynosi:{0:#.##} " , x0);
        }
        else if (delta >= 0)
        {
            double x1 = -b - Math.Sqrt(delta) / 2 * a;
            double x2 = -b + Math.Sqrt(delta) / 2 * a;
            Console.Write("Pierwsze miejsce zerowe:{0:#.##} ",  x1);
            Console.Write(" Drugie miejsce zerowe:{0:#.##}" , x2);

        }
        else if (delta <= 0)
        {
            Console.WriteLine("Delta jest ujemna! Brak miejsc zerowych.");
        }


        /* Console.WriteLine("Wprowadź a, b, c: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        
        if(Math.Pow(a, 2) + Math.Pow(b ,2) == Math.Pow(c, 2))
        {
            Console.WriteLine("Podane wartości spełniają warunki trójkąta pitagorejskiego");
        } else
        {
            Console.WriteLine("Podane wartości nie spełniają warunków trójkąta pitagorejskiego");
        } */

        /* Console.WriteLine("Podaj zmienną x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj zmienną y: ");
        double y = double.Parse(Console.ReadLine());
        double suma = x + y;
        double roznica = x - y;
        double iloczyn = x * y;
        double iloraz = x / y;
        Console.Write("Suma wynosi = {0:#.##}, Różnica wynosi = {1:#.##}, Iloczyn wynosi = {2:#.##}, Iloraz wynosi = {3:#.##}", suma, roznica, iloczyn, iloraz); */




        /*  int a = 37;
        int b = 11;
        int c = a % b;
        Console.WriteLine("Wynik c to: " + c); */


        /* Console.WriteLine("Podaj promień r: ");
        double r = double.Parse(Console.ReadLine());
        double obj = 4 / 3 * Math.PI * Math.Pow(r, 3);
        Console.Write("Objętość kuli o promieniu r = {0:#.##} wynosi = {1:#.##} ", r, obj); */

        /* Console.Write("pi = {0:#.###}" + " pi = {1:#.####}" + " liczba = {2:#.##}", Math.PI, Math.PI, 5.65723); */

        /* double pi = Math.PI;
        Console.WriteLine("pi = {0:#.##}", Math.Sqrt(pi)); */



        /* double pierwiastek = 2;
        Console.WriteLine("Pierwiastek z 2 to: " + Math.Sqrt(pierwiastek)); */



        /* Console.WriteLine("Pi = {0:#.#####}", Math.PI); */





        /* Console.WriteLine("Podaj bok a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok b: ");
        double b = double.Parse(Console.ReadLine());
        double pole = a * b;
        Console.WriteLine("Pole prostokąta wynosi: " + pole); */


    }
}
