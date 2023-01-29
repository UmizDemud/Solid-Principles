using Solid_Principles.classes.GameContext;
using Solid_Principles.src.classes;
using Solid_Principles.src.classes.Features.Basic;
using Solid_Principles.src.classes.GameContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.src.classes.Prefabs
{
    public abstract class CharacterBase : GameObjectBase, IHaveHealth, IVisible
    {
        public static List<CharacterBase> characters { get; set; } = new List<CharacterBase>();
        public ConsoleColor color { get; set; }
        public int speed { get; set; } = 1;
        public int health { get; set; }
        public void moveUp()
        {
            if (position[1] - speed < 0)
            {
                return;
            }
            position[1] -= speed;
            Drawer.render(position[0], position[1] + 1, position[0], position[1], color);
        }
        public void moveLeft()
        {
            if (position[0] - speed < 0)
            {
                return;
            }
            position[0] -= speed;
            Drawer.render(position[0] + 1, position[1], position[0], position[1], color);
        }
        public void moveDown()
        {
            if (position[1] + speed > 30)
            {
                return;
            }
            position[1] += speed;
            Drawer.render(position[0], position[1] - 1, position[0], position[1], color);
        }
        public void moveRight()
        {
            if (position[0] + speed > 30)
            {
                return;
            }
            position[0] += speed;
            Drawer.render(position[0] - 1, position[1], position[0], position[1], color);
        }
        public override void moveTo(int x, int y)
        {
            int tempx = position[0];
            int tempy = position[1];
            position[0] = x; position[1] = y;
            Drawer.render(tempx, tempy, x, y, color);
        }
        public abstract void move(ConsoleKey input);

    }
    public class Character : CharacterBase
    {
        public Character(int y = 0, int x = 0)
        {
            position[1] = x; position[0] = y;
            color = ConsoleColor.Yellow;
            characters.Add(this);
            health = 100;
        }
        public override void move(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.RightArrow:
                    moveRight();
                    break;
                case ConsoleKey.DownArrow:
                    moveDown();
                    break;
                case ConsoleKey.LeftArrow:
                    moveLeft();
                    break;
                case ConsoleKey.UpArrow:
                    moveUp();
                    break;
            }
        }
    }
}
