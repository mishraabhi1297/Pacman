using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class LeftCommand : Command
    {
        /// <summary>
        /// Changes the direction of the Pacman to LEFT
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
                    switch (GameManager.Pac.Facing)
                    {
                        case "EAST":
                            GameManager.Pac.Facing = "NORTH";
                            break;
                        case "WEST":
                            GameManager.Pac.Facing = "SOUTH";
                            break;
                        case "NORTH":
                            GameManager.Pac.Facing = "WEST";
                            break;
                        case "SOUTH":
                            GameManager.Pac.Facing = "EAST";
                            break;
                    }
                    return "";
                }
                return "'LEFT' command does not need any parameters";
            }
            return "Make sure the Pacman is placed on the grid before you can rotate or move it";
        }
    }
}
