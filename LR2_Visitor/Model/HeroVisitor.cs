using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    public class HeroVisitor : ILocationVisitor
    {
        public void Visit(Forest forest)
        {
            Console.WriteLine("Exploring the mysterious forest.");
        }

        public void Visit(Desert desert)
        {
            Console.WriteLine("Surviving the deadly desert.");
        }

        public void Visit(Island island)
        {
            Console.WriteLine("Discovering the lost island.");
        }

        public void Visit(Cave cave)
        {
            Console.WriteLine("Mining crystals in the icy caves.");
        }

        public void Visit(Mountain mountain)
        {
            Console.WriteLine("Climbing the volcanic mountains.");
        }
    }
}
