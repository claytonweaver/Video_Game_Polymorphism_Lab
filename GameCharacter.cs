using System;
using System.Collections.Generic;
using System.Text;

namespace Video_Game_Polymorphism_Additional_Assignment
{
    abstract class GameCharacter
    {
        protected string name;
        protected int strength;
        protected int intelligence;

        public abstract string Name { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Intelligence { get; set; }

        
        
        public virtual void Play()
        {
            Console.WriteLine($"{name}: Strength - {strength} Intelligence - {intelligence}");
        }



    }
}
