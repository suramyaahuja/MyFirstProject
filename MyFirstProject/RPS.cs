

	static class RPS
	{
		public static void rockpaperscissors()
		{
            
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
        

        }
    }


