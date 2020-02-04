using System;
using System.Collections.Generic;

namespace Video_Game_Polymorphism_Additional_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard gandalf = new Wizard("Gandalf the Gray", 30, 500, 432, 60);
            Wizard harryPotter = new Wizard("Harry Potter", 10, 300, 12, 70);
            Wizard herminey = new Wizard("Herminey", 10, 260, 90, 40);
            Warrior shrek = new Warrior("Shrek", 1000, 5, "Club");
            Warrior link = new Warrior("Link", 500, 300, "Sword");


            GameCharacter[] gameCharacters = { gandalf, harryPotter, herminey, shrek, link };

            foreach(var g in gameCharacters)
            {
                g.Play();
            }


        }
    }
}
