using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class SweetTooth : Ninja
    {
        public override  bool IsFull
        {
            get
            {
                return calorieIntake>=1500;
            }
        }
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake +=item.Calories+10;
                if(item.IsSweet)
                {
                    calorieIntake+=10;
                }
                ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());
            }
            else
            {
                Console.WriteLine("SweetTooth is full and cannot eat anymore!");
            }
            
        }
    }
}