using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.src.classes.Features.Basic
{
    interface ICanMove
    {
        public void move(ConsoleKey input);
        public void moveRight();
        public void moveDown();
        public void moveLeft();
        public void moveUp();
    }
}
