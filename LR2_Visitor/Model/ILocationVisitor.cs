using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    public interface ILocationVisitor
    {
        void Visit(Forest forest);
        void Visit(Desert desert);
        void Visit(Island island);
        void Visit(Cave cave);
        void Visit(Mountain mountain);
    }
}
