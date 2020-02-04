using System;
using System.Collections.Generic;
using System.Text;

namespace Video_Game_Polymorphism_Additional_Assignment
{
   abstract class MagicUsingCharacter : GameCharacter
    {
        protected int magicalEnergy;

        public abstract int MagicalEnergy { get; set; }
        public override string Name { get => name; set => name = value; }
        public override int Strength { get => strength; set => strength = value; }
        public override int Intelligence { get => intelligence; set => intelligence = value; }

        public override void Play()
        {
            base.Play();
        }
    }
}
