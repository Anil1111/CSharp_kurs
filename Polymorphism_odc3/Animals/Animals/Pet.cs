﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Pet : Animal, IPet
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public virtual void GiveName() { }
    }
}
