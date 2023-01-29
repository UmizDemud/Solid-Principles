using Solid_Principles.src.classes.Prefabs;

namespace Solid_Principles.classes.ObjectContext.Features
{
    interface IHealer
    {
        public int amount { get; set; }
        public void heal(Character target)
        {
            target.health += amount;
            if (target.health > 140)
            {
                target.health = 140;
            }
        }
    }
}
