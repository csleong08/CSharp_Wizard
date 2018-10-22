using System;
using System.Collections.Generic;

namespace Wizard

{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            hDexterity = 175;
        }
        public void Steal(object obj)
        {
            Human enemy = obj as Human; 
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Steal");
            }
            else
            {
                hHealth += 10;
                System.Console.WriteLine(hHealth);
            }
        }
        public void GetAway()
        {
            hHealth -= 15;
            System.Console.WriteLine(hHealth);
        }
    }
}
