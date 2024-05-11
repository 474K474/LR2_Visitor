﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Model
{
    interface ILocation
    {
        void Accept(ILocationVisitor visitor);
    }
}
