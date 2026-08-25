using CapstoneProject.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Items
{
    internal class Weapon : Item
    {
        public int Damage { get; set; }

        public override void Use(Character target)
        {
        }
    }
}
