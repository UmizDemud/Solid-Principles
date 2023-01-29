using Solid_Principles.src.classes.Prefabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.classes.GameContext
{
    public class Drawer
    {
        public const int cols = 20;
        public const int rows = 20;

        public static ConsoleColor[,] hash = new ConsoleColor[cols, rows];

        public static ConsoleColor getColor(int x, int y)
        {
            foreach (var character in Character.characters)
            {
                if (character.position[0] == x && character.position[1] == y)
                {
                    return character.color;
                }
            }
            return ConsoleColor.White;
        }
        public static void Setup()
        {
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    hash[j, i] = ConsoleColor.White;
                }
            }
            foreach (var character in Character.characters)
            {
                if (character.health <= 0)
                {
                    continue;
                }
                hash[character.position[1], character.position[0]] = character.color;
            }
        }

        public static void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    Console.BackgroundColor = hash[j, i];
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void render(int fromX, int fromY, int toX, int toY, ConsoleColor color)
        {
            Console.SetCursorPosition(fromX * 2, fromY);
            Console.BackgroundColor = getColor(fromX, fromY);
            Console.Write("  ");
            Console.SetCursorPosition(toX * 2, toY);
            Console.BackgroundColor = color;
            Console.Write("  ");
        }

        public static void Close()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 24);
        }
    }
}
