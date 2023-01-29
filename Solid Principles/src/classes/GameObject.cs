using Solid_Principles.classes.GameContext;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.src.classes.GameContext
{
    interface ITransform
    {
        public int[] position { get; set; }
    }
    public abstract class GameObjectBase : ITransform
    {
        public int[] position { get; set; } = new int[2];

        public abstract void moveTo(int x, int y);
    }
    public class GameObject: GameObjectBase
    {
        public GameObject()
        {
            position[0] = 0; position[1] = 0;
        }

        public override void moveTo(int x, int y)
        {
            int tempx = position[0];
            int tempy = position[1];
            position[0] = x; position[1] = y;
            Drawer.render(tempx, tempy, x, y, ConsoleColor.Black);
        }
    }
}
