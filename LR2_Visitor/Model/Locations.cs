using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    public  class Forest : ILocation
    {
        public void Accept(ILocationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Desert : ILocation
    {
        public void Accept(ILocationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Island : ILocation
    {
        public void Accept(ILocationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Cave : ILocation
    {
        public void Accept(ILocationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Mountain : ILocation
    {
        public void Accept(ILocationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
