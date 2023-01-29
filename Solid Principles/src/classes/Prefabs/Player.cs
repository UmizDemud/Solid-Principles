using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Principles.classes.ObjectContext.Features;
using Solid_Principles.src.classes.Prefabs;
using static System.Net.Mime.MediaTypeNames;

namespace Solid_Principles.classes.ObjectContext.Prefabs
{
    internal abstract class PlayerBase : Character, IHealer, IShooter
    {
        public int damage { get; set; } = 10;
        public int amount { get; set; } = 10;
        public abstract void respawn();
    }
    internal class Player : PlayerBase
    {
        public Player(int y = 0, int x = 0)
        {
            position[1] = x; position[0] = y;
            color = ConsoleColor.Blue;
            health = 100;
        }

        public override void respawn()
        {
            position[1] = 0; position[0] = 0;
            health = 100;
        }
    }
}
