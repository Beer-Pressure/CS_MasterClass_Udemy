using CapstoneProject.Inventory;

namespace CapstoneProject.Characters
{
    internal abstract class Character
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int AttackPower { get; set; }

        public CapstoneProject.Inventory.Inventory Inventory { get; set; }

        public virtual void TakeDamage(int amount)
        {
        }

        public virtual void Heal(int amount)
        {
        }

        public abstract void Attack(Character target);
    }
}
