using CapstoneProject.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Items
{
    internal abstract class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public abstract void Use(Character target);
    }
}
