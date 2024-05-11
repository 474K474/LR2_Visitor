using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    class HeroBuilder
    {
        private string name = "Default Hero";
        private int health = 100;
        private int strength = 10;

        public HeroBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public HeroBuilder SetHealth(int health)
        {
            this.health = health;
            return this;
        }

        public HeroBuilder SetStrength(int strength)
        {
            this.strength = strength;
            return this;
        }

        public Hero Build()
        {
            return new Hero(name, health, strength);
        }
    }
}
