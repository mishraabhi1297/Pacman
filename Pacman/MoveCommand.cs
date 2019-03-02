using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class MoveCommand: Command
    {
        /// <summary>
        /// Moves the Pacman by 1 units depending on the direction it is facing
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override String execute(String input)
        {
            String[] inputArr = input.Split(' ');

            if (GameManager.Pac != null)
            {
                if (inputArr.Length == 1)
                {
                    int x = GameManager.Pac.X;
                    int y = GameManager.Pac.Y;
                    String facing = GameManager.Pac.Facing;

                    if ((facing == "NORTH") && (y < 5))
                    {
                        GameManager.Pac.Y++;
                        return "";
                    }
                    else if ((facing == "SOUTH") && (y > 0))
                    {
                        GameManager.Pac.Y--;
                        return "";
                    }
                    else if ((facing == "WEST") && (x > 0))
                    {
                        GameManager.Pac.X--;
                        return "";
                    }
                    else if ((facing == "EAST") && (x < 5))
                    {
                        GameManager.Pac.X++;
                        return "";
                    }
                    else
                    {
                        return "Cannot move off the grid";
                    }
                }
                return "'MOVE' command does not need any parameters";
            }
            return "Make sure the Pacman is placed on the grid before you can rotate or move it";
        }
    }
}
