using Solid_Principles.classes.GameContext;
using Solid_Principles.classes.ObjectContext.Features;
using Solid_Principles.classes.ObjectContext.Prefabs;
using Solid_Principles.src.classes;
using Solid_Principles.src.classes.Prefabs;

var karakter = new Player(2, 4);
var karakter2 = new Character(4, 8);

Drawer.Setup();
Drawer.Draw();

ConsoleKey input;

while (true)
{
    input = Console.ReadKey(true).Key;

    if (input == ConsoleKey.Escape)
    {
        break;
    }

    karakter.move(input);
}

Drawer.Close();
