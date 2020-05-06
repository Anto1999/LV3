using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Prototype
    {
        Prototype Clone();
        Prototype DeepClone();
    }
}
