using System;

class Program
{
    static void Main(string[] args)
    {

        {
            Random random = new Random();
            int losowa = random.Next(1, 11);
            int zgadywana = 0;
            int proba = 0;
            while (proba < 3 && zgadywana != losowa)
            {
                Console.Write("Zgadnij liczbę z zakresu od 1 do 10: ");
                zgadywana = int.Parse(Console.ReadLine());
                if (zgadywana < 1 || zgadywana > 10)
                {
                    Console.WriteLine("To nie ten zakres!");
                    continue;
                }
                else
                {
                    proba++;
                    
                    if (zgadywana > losowa)
                    {
                        Console.WriteLine("Za dużo!");
                    }
                    else if (zgadywana < losowa)
                    {
                        Console.WriteLine("Za mało!");
                    }
                }
                if (zgadywana != losowa)
                {
                    int pozostalo = 3 - proba;
                    Console.WriteLine($"Nie zgadłeś! Spróbuj ponownie!. Pozostało ci {pozostalo} próby");
                }

            }
            switch (losowa == zgadywana)
            {
                case true:
                    {
                        Console.WriteLine("Zgadłeś!");
                    }
                    break;
                case false:
                    {
                        Console.WriteLine("Nie zgadłeś! Liczba, o którą chodziło to: " + losowa);
                    }
                    break;
            }
        }
    }
}
                    


                
                    
                    



             
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            









        /* Console.WriteLine("Zgadnij liczbę od 1 do 9");
        int zgadywana = int.Parse(Console.ReadLine());
        double losowa;
        Random random = new Random();
        losowa = Math.Round(10 * (random.NextDouble()));
        if (losowa == zgadywana)

        {
            Console.WriteLine("Zgadłeś!");
        } else
        {
            Console.WriteLine("Nie zgadłeś ! :(");
        }
    }
} */

/* Console.WriteLine("Podaj wartości a,b,c: ");
 double a = double.Parse(Console.ReadLine());
 double b = double.Parse(Console.ReadLine());
 double c = double.Parse(Console.ReadLine());
 double x = (c - b) / a;
 double y = 0.25;
 Console.WriteLine(y.ToString("0.000"));
 switch (a)
 {
     case 0:
         {
             Console.WriteLine("a musi być różne od zera! ");
         }
         break;
     default:
         {
             Console.WriteLine("Wynik to: " + x.ToString("0.###"));
         }
         break;
 }
}
} */


/* Console.WriteLine("Podaj numer od 1 do 7:");

int liczba = int.Parse(Console.ReadLine());

switch (liczba)
{
    case 1:
        {
            Console.WriteLine("Poniedziałek");
        }
        break;
    case 2:
        {
            Console.WriteLine("Wtorek");
        }
        break;
    case 3:
        {
            Console.WriteLine("Środa");
        }
        break;
    case 4:
        {
            Console.WriteLine("Czwartek");
        }
        break;
    case 5:
        {
            Console.WriteLine("Piątek");
        }
        break;
    case 6:
        {
            Console.WriteLine("Sobota");
        }
        break;
    case 7:
        {
            Console.WriteLine("Niedziela");
        }
        break;
    default:
        Console.WriteLine("Zła liczba");
        break;

}
}
}















/* Console.WriteLine("Podaj liczby rzeczywiste: a,b,c");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double delta = (Math.Pow(b, 2) - 4 * a * c);
Console.WriteLine("Delta wynosi: " + delta);
byte liczba = 0;

if (delta < 0)
{
    liczba = 0;
}
if (delta == 0)
{
    liczba = 1;
}
if (delta > 0)
{
    liczba = 2;
}
switch (liczba)
{
    case 0:
        {
            Console.WriteLine("Brak miejsc zerowych");
        }
        break;
    case 1:
        {
            Console.WriteLine("Przechodzę do liczenia jednego miejsca zerowego");
            double x0 = -b / (2 * a);
            Console.WriteLine("Funkcja z jednym miejscem zerowym wynosi: {0:#.##}", x0);
        }
        break;
      case 2:
        {
            Console.WriteLine("Obliczanie dwóch miejsc zerowych");
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Pierwsze miejsce zerowe wynosi: {0:#.##}", x1);
            Console.WriteLine("Drugie miejsce zerowe wynosi: {0:#.##}", x2);
        }


        break; 
    default:
        Console.WriteLine("Nieprawidłowy numer");
        break;
}


}
} 




















/* Liczenie delty 
Console.WriteLine("Podaj a, b, c: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double delta = Math.Pow(b, 2) - 4 * a * c;
if (a == 0)
{
    Console.WriteLine("A jest równe 0! Przechodzę do wzoru funkcji liniowej");
    if (b == 0)
    {
        Console.WriteLine("Brak miejsc zerowy(b = 0)! Funkcja jest stała");
    }
    else
    {
        double x3 = (-c / b);
        Console.WriteLine("Miejsce zerowe funkcji linowej to: {0:#.##} ", x3);
    }

}
else if (delta == 0)
{
    double x0 = -b / (2 * a);
    Console.WriteLine("Delta z jednym miejscem zerowym wynosi:{0:#.##} " , x0);
}
else if (delta > 0)
{
    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.Write("Pierwsze miejsce zerowe:{0:#.##} ",  x1);
    Console.Write(" Drugie miejsce zerowe:{0:#.##}" , x2);

}
else if (delta < 0)
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











