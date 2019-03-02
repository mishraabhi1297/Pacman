using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class PlaceCommand: Command
    {
        String[] directions = new String[] { "EAST", "WEST", "NORTH", "SOUTH" };
        Vector2D _gridSize;

        public PlaceCommand(Vector2D gridSize)
        {
            _gridSize = gridSize;
        }

        public override String execute(String input)
        {
            String[] inputArr = input.Split(' ');
            if(inputArr.Length == 2)
            {
                String[] command = inputArr[1].Split(',');
                if (command.Length == 3)
                {
                    if (checkPacmanInitialPosition(Int32.Parse(command[0]), Int32.Parse(command[1])))
                    {
                        if (checkPacmanFacing(command[2].ToUpper()))
                        {
                            GameManager.Pac = new Pacman(Int32.Parse(command[0]), Int32.Parse(command[1]), command[2].ToUpper());
                            return "";
                        }
                        return "Error. Direction can only be NORTH, SOUTH, EAST, WEST";
                    }
                    return "Error. Please enter a size of " + _gridSize.X + " units x " + _gridSize.Y + " units";
                }
                return "Error. Please enter 3 elements as follows, Position X, Position Y and Direction";
            }
            return "Error. Please enter the details of Place Command (i.e., PLACE 1,1,NORTH)";
            
        }

        bool checkPacmanInitialPosition(int x, int y)
        {
            return (x <= _gridSize.X) && (y <= _gridSize.Y);
        }

        bool checkPacmanFacing(String dir)
        {
            bool result = false;

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == dir)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
