using CapstoneProject.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Items
{
    internal class Armor : Item
    {
        public int DefenseBonus { get; set; }

        public override void Use(Character target)
        {
        }
    }
}
