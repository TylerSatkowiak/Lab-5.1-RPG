using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Lab_5._1_RPG
{
    class RPGCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public RPGCharacter(string name, int STR, int INT)
        {
            Name = name;
            Strength = STR;
            Intelligence = INT;
        }
        public virtual void Play()
        {
            Console.WriteLine($"This is a useless line of code :) ");
        }
    }

    class Warrior : RPGCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string name, int STR, int INT, string weapon) : base(name, STR, INT)
        {
            WeaponType = weapon;
        }

        public override void Play()
        {
            Console.WriteLine($"\n{Name} enters the arena weilding a {WeaponType}. (Strength: {Strength} Intelligence: {Intelligence})");
        }
    }

    class MagicUser : RPGCharacter
    {
        public int MagicEnergy { get; set; }
        public MagicUser(string name, int STR, int INT, int MagicalEnergy) : base(name, STR, INT)
        {
            MagicEnergy = MagicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"\n{Name} enters the arena with {MagicEnergy} magic energy. (Strength: {Strength} Intelligence {Intelligence})");
        }
    }


    class Wizard : MagicUser
    {
        public int SpellNumber { get; set; }

        public Wizard(string name, int STR, int INT, int MagicalEnergy, int Spells) : base(name, STR, INT, MagicalEnergy)
        {
            SpellNumber = Spells;
        }
        public override void Play()
        {
            Console.WriteLine($"\n{Name} enters the arena with {MagicEnergy} magic energy and {SpellNumber} spell(s). (Strength: {Strength} Intelligence: {Intelligence})");
        }
    }

    class Program
    {
        static void Main()
        {
            List<RPGCharacter> GameCharacters = new List<RPGCharacter>
            {
                new Warrior("Draughr", 16, 9, "Giant Maul"),
                new Warrior("Maul the Impaler", 18, 5, "The Impaler"),
                new Warrior("Tryndamere", 15, 11, "Blood Gusher"),
                new Wizard("Merlin", 9, 18, 4, 3),
                new Wizard("Gandalf", 14, 18, 6, 4),
                new Wizard("DOOMguy", 9001, 1, 1, 1)
            };

            Console.WriteLine("THIS IS THE ULTIMATE SHOWDOWN, OF ULTIMATE DESTINY!");

            foreach (RPGCharacter character in GameCharacters)
            {
                character.Play();
            }

        }
    }
}