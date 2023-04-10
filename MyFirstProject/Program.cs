using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello, World!");
        Console.WriteLine("Okay");
        Console.Beep();
        //comment

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

        /* Console.WriteLine("\n If-else \n");
        Console.WriteLine("Enter age");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if (age2 >= 18 && age2<100)
        {
            Console.WriteLine("You are allowed to sign up.");
        }
        else
        {
            Console.WriteLine("You must be 18+ to sign up.");
        } */

        Console.WriteLine("\n Nested loop \n");


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

      

        /*
        Console.WriteLine("\n Rock, Paper, Scissors game \n");

        
        Random r = new Random();
        bool playAgain2 = true;

        while (playAgain2)
        {
            String player = "";
            String comp = "";
            String h = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter rock, paper or scissors.");
                player = Console.ReadLine();
                player = player.ToUpper();
            }
            
            switch(r.Next(1, 4))
            {
                case 1:
                    comp = "ROCK";
                    break;
                case 2:
                    comp = "PAPER";
                    break;
                case 3:
                    comp = "SCISSORS";
                    break;
            }
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + comp);

            switch (player)
            {
                case "ROCK":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }



            Console.WriteLine("Do you want to play again(Y/N)?");
            h = Console.ReadLine();
            h = h.ToUpper();
            if (h == "Y")
            {
                playAgain2 = true;
            }
            else
            {
                playAgain2 = false;
            }
        }
        */
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

