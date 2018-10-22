using System;

namespace Wizard
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            // Samurai Meditate method
            Samurai mySamurai = new Samurai("Kenshin");
            Wizard myWizard = new Wizard("Ace");
            System.Console.WriteLine(mySamurai.hHealth);
            object BoxedData = mySamurai;
            myWizard.Fireball(BoxedData);
            System.Console.WriteLine(mySamurai.hHealth);
            myWizard.Fireball(BoxedData);
            System.Console.WriteLine(mySamurai.hHealth);
            myWizard.Fireball(BoxedData);
            System.Console.WriteLine(mySamurai.hHealth);
            myWizard.Fireball(BoxedData);
            System.Console.WriteLine(mySamurai.hHealth);
            mySamurai.Meditate();
            System.Console.WriteLine(mySamurai.hHealth);

            // // Samurai DeathBlow method
            // Samurai mySamurai = new Samurai("Kenshin");
            // Wizard myWizard = new Wizard("Gandalf");
            // object BoxedData = myWizard;
            // System.Console.WriteLine(myWizard.hHealth);
            // mySamurai.Attack(BoxedData);
            // System.Console.WriteLine(myWizard.hHealth);
            // mySamurai.DeathBlow(BoxedData);
            // System.Console.WriteLine(myWizard.hHealth);

            // // Ninja GetAway method
            // Ninja myNinja = new Ninja("Sasuke");
            // myNinja.GetAway();
            // System.Console.WriteLine(myNinja.hHealth);

            // // Ninja Steal method
            // Ninja myNinja = new Ninja("Naruto");
            // object BoxedData = myNinja;
            // myNinja.Steal(BoxedData);
            // System.Console.WriteLine(myNinja.hHealth);

            // // Human Attack method
            // Wizard myWizard = new Wizard("Ace");
            // object BoxedData = myWizard;
            // myWizard.Fireball(BoxedData);
            // System.Console.WriteLine(myWizard.hHealth);

            // // Wizard Heal method
            // Wizard myWizard = new Wizard("Gandalf");
            // myWizard.Heal();
            // System.Console.WriteLine(myWizard.hHealth);

            // // Human Attack method
            // Human myHuman = new Human("Luffy");
            // object BoxedData = myHuman;
            // myHuman.Attack(BoxedData);
            // System.Console.WriteLine(myHuman.hHealth);
        }
    }
}
