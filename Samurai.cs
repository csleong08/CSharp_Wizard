using System;
using System.Collections.Generic;

namespace Wizard

{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            hHealth = 200;
        }
        public void DeathBlow(object obj)
        {
            Human enemy = obj as Human; 
            if (enemy == null | enemy.hHealth>49)
            {
                System.Console.WriteLine("Failed Death Blow");
            }
            else
            {
                enemy.hHealth = 0;
            }
        }
        public void Meditate()
        {
            hHealth = 200;
        }
    }
}