using CapstoneProject.Interfaces;
using CapstoneProject.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.NPCs
{
    internal class Merchant : NPC, ITradable
    {
        public CapstoneProject.Inventory.Inventory ShopInventory { get; set; }

        public void Buy(Item item)
        {
        }

        public void Sell(Item item)
        {
        }
    }
}
