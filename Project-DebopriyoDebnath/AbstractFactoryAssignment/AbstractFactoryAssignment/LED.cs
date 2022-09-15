﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    class LED : CarLight
    {
        public override string DisplayLight()
        {
            return String.Format(this.GetType().Name + " light.");
        }
    }
}
