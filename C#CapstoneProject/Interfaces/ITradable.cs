using CapstoneProject.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Interfaces
{
    internal interface ITradable
    {
        void Buy(Item item);

        void Sell(Item item);
    }
}
