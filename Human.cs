using System;
using System.Collections.Generic;

namespace Wizard

{
    public class Human 
    {
        public string hName { get; set; }
        public int hStrength { get; set; }
        public int hIntelligence { get; set; }
        public int hDexterity { get; set; }
        public int hHealth { get; set; } 

        public Human(string name) 
        {
            hName = name;
            hStrength = 3;
            hIntelligence = 3;
            hDexterity = 3;
            hHealth = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp) 
        {
            hName = name;
            hStrength = str;
            hIntelligence = intel;
            hDexterity = dex;
            hHealth = hp;
        }

        public void Attack(object obj)
        {
            Human enemy = obj as Human; 
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.hHealth -= 5 * hStrength;
            }
            
        }
    }
}