using System;
using System.Collections.Generic;

namespace Wizard

{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            hHealth = 50;
            hIntelligence = 25; 
        }
        public void Heal()
        {
            hHealth += 10 * hIntelligence;
        }

        public void Fireball(object obj)
        {
            Random rand = new Random();
            Human enemy = obj as Human; 
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Fireball");
            }
            else
            {
                int Fireball = rand.Next(20,51);
                enemy.hHealth -= Fireball;
                System.Console.WriteLine(Fireball);
            }
        }
    }
}