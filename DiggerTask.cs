using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }
    }

    public class Player : ICreature
    {

        public static int currentX = 0;
        public static int currentY = 0;

        public CreatureCommand Act(int x, int y)
        {
            switch (Game.KeyPressed)
            {
                case Keys.Up:
                    currentY = -1;
                    break;
                case Keys.Down:
                    currentY = 1;
                    break;
                case Keys.Left:
                    currentX = -1;

                    break;
                case Keys.Right:
                    currentX = 1;
                    break;
                default:
                    currentX = 0;
                    currentY = 0;
                    break;
            }
            return new CreatureCommand() { DeltaX = currentX, DeltaY = currentY };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }

}
