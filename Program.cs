using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet chinese=new Buffet();
            SweetTooth sweety=new SweetTooth();
            SpiceHound spicy=new SpiceHound();

            while(!sweety.IsFull)
            {
                sweety.Consume(chinese.Serve());
            }
            while(!spicy.IsFull)
            {
                spicy.Consume(chinese.Serve());
            }
            if (spicy.ConsumptionHistory.Count>sweety.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Spice Hound has {spicy.ConsumptionHistory.Count} items.");
            }
            else
            {
                Console.WriteLine($"Sweet Tooth has {sweety.ConsumptionHistory.Count} items.");
            }
        }
    }
}
