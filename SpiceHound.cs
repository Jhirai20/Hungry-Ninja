using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public int CalorieLimit=1200;
        public override bool IsFull {
            get
            {
                return calorieIntake>=1200;
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(!IsFull)
            {
                calorieIntake+=item.Calories;
                if(item.IsSpicy)
                {
                    calorieIntake -=5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else
            {
                Console.WriteLine("Spice Hound is full!");
            }
        }
    }
}