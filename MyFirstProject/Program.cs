using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello, World!");
        Console.WriteLine("Okay");
        Console.Beep();
     

        double z = 10 + 20.04;
        Console.WriteLine("Value of z is: " + z + " units");

        char c = '@';
        String name = "Suramya";
        String username = c + name;
        Console.WriteLine("Your username is " + username);

        const double pi = 3.14;
        int a = Convert.ToInt32(pi);
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());

        int b = 321;
        String d = Convert.ToString(b);
        Console.WriteLine(d);

        /* Console.WriteLine("Enter your favourite colour");
        String col = Console.ReadLine();
        Console.WriteLine("Your favourite colour is " +col);

        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You are {age} years old."); // String interpolation
        */

        int e = 50;
        e++;
        Console.WriteLine(e);
        int rem = e % 10;
        Console.WriteLine(rem);

        Console.WriteLine("\n Math Functions: \n");

        double x = 3;
        double f = -2;
        double y = 5;
        double g = 3.9;

        Console.WriteLine(Math.Pow(x, 2));
        Console.WriteLine(Math.Sqrt(x));
        Console.WriteLine(Math.Abs(g));
        Console.WriteLine(Math.Round(z));
        Console.WriteLine(Math.Ceiling(z));
        Console.WriteLine(Math.Floor(z));
        Console.WriteLine(Math.Max(z, y));
        Console.WriteLine(Math.Min(x, g));

        Console.WriteLine("\n Random Number: \n");
        Random random = new Random();
        int num1 = random.Next(1, 7);
        int num2 = random.Next(1, 7);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        double num = random.NextDouble();
        Console.WriteLine(num);

        Console.WriteLine("\n String Methods \n");
        String fullName = "John Doe";
        String phoneNumber = "123-456-7890";

        fullName = fullName.ToUpper();
        fullName = fullName.ToLower();
        Console.WriteLine(fullName);
        phoneNumber = phoneNumber.Replace("-", " ");
        Console.WriteLine(phoneNumber);

        String userName = fullName.Insert(0, "Mr.");
        Console.WriteLine(userName);

        Console.WriteLine(fullName.Length);

        String firstName = fullName.Substring(0, 4);
        String lastName = fullName.Substring(5, 3);

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        // age.allowed();

        Console.WriteLine("\n Nested loop \n");


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // numbergame.NumberGame();

        // RPS.rockpaperscissors();

        Console.WriteLine("\n Array \n");
        String[] cars = { "BMW", "Mustang", "Skoda" };
        foreach (String CAR in cars)
        {
            Console.WriteLine(CAR);
        }
        Console.WriteLine("\n params \n");
        double total = checkout(10, 67.99, 56.45, 30);
        Console.WriteLine("Total price is Rs. " + total);


        /*
          Console.WriteLine("\n Exception Handling \n");
             public double l;
             public double m;
             public double ans;
             try
             {
                 Console.WriteLine("Enter 2 nos.");
                 l = Convert.ToDouble(Console.ReadLine());
                 m = Convert.ToDouble(Console.ReadLine());
                 ans = l / m;
                 Console.WriteLine(ans);
             }
             catch (FormatException k)
             {
                 Console.WriteLine("Enter ONLY numbers!");
             }
             finally
             {
                 Console.WriteLine("Thanks");
             }
         */


        Console.WriteLine("\n Multidimensional Arrays \n");
        String[,] categories =
        {
            {"pink", "white", "purple" },
            {"cat", "dog", "rabbit"},
            {"TV","laptop","tablet" }
        };
        int o; int p;
        categories[2, 1] = "desktop";
        for (o = 0; o < categories.GetLength(0); o++)
        {
            for (p = 0; p < categories.GetLength(1); p++)
            {
                Console.Write(categories[o, p] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n Inheritance \n");

        Car car = new Car();
        Console.WriteLine("Speed: " + car.speed);
        Console.WriteLine("No. of wheels: " + car.wheels);
        car.go();

        Console.WriteLine("\n Array of Objects \n");

        Vehicle2[] garage = { new Vehicle2("truck"), new Vehicle2("bike"), new Vehicle2("jeep") };
        foreach (Vehicle2 q in garage){
            Console.WriteLine(q.type);
        }

        Console.WriteLine("\n params argument \n");
        static double checkout(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total = total + price;
            }
            return total;
        }

        Console.WriteLine("\n Polymorphism \n");
        CarP carP = new CarP();
        BicycleP bicycleP = new BicycleP();
        BoatP boatP = new BoatP();

        VehicleP[] vehicles = { carP, bicycleP, boatP };

        foreach (VehicleP vehicle in vehicles)
        {
            vehicle.Go();
        }

        Console.WriteLine("\n Interfaces \n");
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        Console.WriteLine("\n Lists \n");
        list.foodlist();

        Console.WriteLine("\n Enums \n");
        String name2 = PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        Console.WriteLine("planet: " + name2);
        Console.WriteLine("radius: " + radius + "km");

    }
}

class Vehicle
{
    public int speed = 20;
 
    public void go()
        
    {
        Console.WriteLine("This vehicle is moving");
    }
  
}

class Car: Vehicle
{
    public int wheels = 4;
}

class Vehicle2{

public string type;
public Vehicle2(String type)
{
    this.type = type;
}
}

class VehicleP
{
    public virtual void Go()
    {

    }
}
class CarP : VehicleP
{
    public override void Go()
    {
        Console.WriteLine("The car is moving!");
    }
}
class BicycleP : VehicleP
{
    public override void Go()
    {
        Console.WriteLine("The bicycle is moving!");
    }
}
class BoatP : VehicleP
{
    public override void Go()
    {
        Console.WriteLine("The boat is moving!");
    }
}

interface IPrey{
    void Flee();
}
interface IPredator
{
    void Hunt();
}
class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit runs away");
    }
}
class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("The hawk is searching for food!");
    }
}
class Fish : IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine("The fish swims away!");
    }
    public void Hunt()
    {
        Console.WriteLine("The fish is searching for smaller fish!");
    }
}

enum Planets
{
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupiter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9
}

enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}