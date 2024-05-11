using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    class Hero : ILocationVisitor
    {
        public string Name { get; }
        public int Health { get; }
        public int Strength { get; }

        public Hero(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public void Visit(Forest forest)
        {
            Console.WriteLine($"{Name} explores the mysterious forest with health {Health} and strength {Strength}.");
        }

        public void Visit(Desert desert)
        {
            Console.WriteLine($"{Name} survives the deadly desert with health {Health} and strength {Strength}.");
        }

        public void Visit(Island island)
        {
            Console.WriteLine($"{Name} discovers the lost island with health {Health} and strength {Strength}.");
        }

        public void Visit(Cave cave)
        {
            Console.WriteLine($"{Name} mines crystals in the icy caves with health {Health} and strength {Strength}.");
        }

        public void Visit(Mountain mountain)
        {
            Console.WriteLine($"{Name} climbs the volcanic mountains with health {Health} and strength {Strength}.");
        }
    }
}
