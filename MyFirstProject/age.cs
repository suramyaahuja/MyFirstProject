static class age
{
    public static void allowed()
    {
        Console.WriteLine("\n If-else \n");
        Console.WriteLine("Enter age");
        int age2 = Convert.ToInt32(Console.ReadLine());
        if (age2 >= 18 && age2 < 100)
        {
            Console.WriteLine("You are allowed to sign up.");
        }
        else
        {
            Console.WriteLine("You must be 18+ to sign up.");
        }
    }
}