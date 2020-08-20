using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy;
            public bool IsSweet;
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food (string name,int calories, bool isSpicy, bool isSweet)
            {
                Name=name;
                Calories=calories;
                IsSpicy=isSpicy;
                IsSweet=isSweet;
            }
        }
        class Buffet
        {
            public List<Food> Menu;
            //Constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Pizza", 1000,false,false),
                    new Food("Speghetti", 1500,false,false),
                    new Food("Chicken Wings", 500,true,false),
                    new Food("Swedish Meatballs", 900,false,false),
                    new Food("Ramen", 800,false,false),
                    new Food("Soba Noodles", 300,false,false),
                    new Food("Green Curry", 450,true,true),
                    new Food("Brownies", 450,false,true)
                };
            }
            public Food Serve()
            {
                Random rand= new Random();
                return Menu[rand.Next(Menu.Count)];
            }
        }
        class Ninja 
        {
            private int calorieIntake;
            private int calorieLimit;
            public List<Food> FoodHistory;
            public Ninja()
            {
                this.calorieIntake=0;
                this.calorieLimit=1200;
                this.FoodHistory=new List<Food>();
            }
            public bool IsFull
            {
                get {return calorieIntake>=calorieLimit;}
            }
            public void Eat(Food item)
            {   
                if(this.IsFull)
                {
                    throw new Exception("Ninja is full");
                }
                else
                {
                    
                    this.calorieIntake +=item.Calories;
                    this.FoodHistory.Add(item);
                    Console.WriteLine("Ninja eating "+item.Name );
                    if (item.IsSpicy==true){Console.Write("Its spicy!");}
                    if (item.IsSweet==true){Console.Write("Its sweet!");}
                }

            }
        }
        static void Main(string[] args)
        {
            Buffet chinese=new Buffet();
            Ninja Jeff =new Ninja();
            while(!Jeff.IsFull)
            {
                Jeff.Eat(chinese.Serve());
            }
            
        }
    }
}
