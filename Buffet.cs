using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
        class Buffet
        {
            public List<IConsumable> Menu;
            //Constructor
            public Buffet()
            {
                Menu = new List<IConsumable>()
                {
                    new Food("Pizza", 1000,false,false),
                    new Food("Speghetti", 1500,false,false),
                    new Food("Chicken Wings", 500,true,false),
                    new Food("Swedish Meatballs", 900,false,false),
                    new Food("Ramen", 800,false,false),
                    new Food("Soba Noodles", 300,false,false),
                    new Food("Green Curry", 450,true,true),
                    new Food("Brownies", 450,false,true),
                    new Food("Bubble Tea", 450,false,true)
                };
            }
            public IConsumable Serve()
            {
                Random rand= new Random();
                return Menu[rand.Next(Menu.Count)];
            }
        }
}