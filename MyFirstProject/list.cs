﻿using System.Collections.Generic;

	static class list
	{
		public static void foodlist()
		{
        List<String> food = new List<String>();

        food.Add("pizza");
        food.Add("hamburger");
        food.Add("hotdog");
        food.Add("fries");

        //Console.WriteLine(food[0]);
        //Console.WriteLine(food[1]);
        //Console.WriteLine(food[2]);
        //Console.WriteLine(food[3]);

        //food.Remove("fries");
        food.Insert(0, "sushi");
        Console.WriteLine(food.Count);
        //Console.WriteLine(food.IndexOf("pizza"));
        //Console.WriteLine(food.LastIndexOf("fries"));
        //Console.WriteLine(food.Contains("pizza"));
        food.Sort();
        //food.Reverse();
        //food.Clear();
        String[] foodArray = food.ToArray();

        foreach (String item in food)
        {
            Console.WriteLine(item);
        }
    }
	}


