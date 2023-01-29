using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Principles.classes.ObjectContext.Features;
using Solid_Principles.src.classes.Prefabs;

namespace Solid_Principles.classes.ObjectContext.Prefabs
{
    public class Boss : Character, IShooter, ISummoner
    {
        public int damage { get; set; } = 30;
        public Dictionary<string, Func<CharacterBase>> summons { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void attack(int damage, int targetX, int targetY)
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
        public Boss(int y = 0, int x = 0)
        {
            position[1] = x; position[0] = y;
            color = ConsoleColor.Red;
            health = 300;
        }
    }
}
