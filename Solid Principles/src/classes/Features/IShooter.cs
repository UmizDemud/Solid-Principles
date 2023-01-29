using Solid_Principles.src.classes.Prefabs;

namespace Solid_Principles.classes.ObjectContext.Features
{
    interface IShooter
    {
        public int damage { get; set; }
        public void attack(int targetX, int targetY)
        {
            var characters = Character.characters;
            var subset = from character in characters
                         where character.position[0] == targetX &&
                         character.position[1] == targetY
                         select character;

            foreach (var character in subset)
            {
                if (character.health < damage)
                {
                    characters.Remove(character);
                }
                else
                {
                    character.health -= damage;
                }
            }
        }
    }
}
