using CapstoneProject.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Items
{
    internal class Potion : Item
    {
        public int HealAmount { get; set; }

        public override void Use(Character target)
        {
        }
    }
}
