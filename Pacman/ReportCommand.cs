using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class ReportCommand : Command
    {
        /// <summary>
        /// Returns the current position and orientation of Pacman
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
                    return "Output: " + GameManager.Pac.X + "," + GameManager.Pac.Y + "," + GameManager.Pac.Facing;
                }
                return "'REPORT' command does not need any parameters";
            }
            return "Make sure the Pacman is placed on the grid before you can rotate or move it";
        }
    }
}
