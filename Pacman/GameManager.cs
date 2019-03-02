using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public static class GameManager
    {
        static bool isRunning = true;
        static Pacman pac;
        static Command _command;
        static String _input;
        static String _message = "";
        static Vector2D gridSize = new Vector2D(5, 5);

        public static Pacman Pac { get => pac; set => pac = value; }

        /// <summary>
        /// Processes the user input and calls the corresponding function
        /// </summary>
        private static void processInput()
        {
            Console.WriteLine("\nPlease enter a command ('EXIT' to close the terminal): ");
            _input = Console.ReadLine();
            String[] inputArr = _input.Split(' ');

            if (inputArr[0].ToUpper() == "EXIT")
            {
                isRunning = false;
            }
            else
            {
                switch (inputArr[0].ToUpper())
                {
                    case "PLACE":
                        _command = new PlaceCommand(gridSize);
                        break;
                    case "LEFT":
                        _command = new LeftCommand();
                        break;
                    case "RIGHT":
                        _command = new RightCommand();
                        break;
                    case "MOVE":
                        _command = new MoveCommand();
                        break;
                    case "REPORT":
                        _command = new ReportCommand();
                        break;
                    default:
                        _command = null;
                        _message = "Please input a valid command (i.e., PLACE, LEFT, RIGHT, MOVE, REPORT)";
                        break;
                }
            }
        }

        /// <summary>
        /// Updates the game
        /// </summary>
        private static void updateGame()
        {
            if (_command != null)
            {
                _message = _command.execute(_input);
            }
        }

        /// <summary>
        /// Renders any message that needs to be displayed
        /// </summary>
        private static void render()
        {
            if (_message != "")
            {
                Console.WriteLine(_message);
            }
        }

        /// <summary>
        /// Main game loop (Will continue until user enters 'EXIT')
        /// </summary>
        public static void gameLoop()
        {
            while (isRunning)
            {
                processInput();
                if (isRunning)
                {
                    updateGame();
                    render();
                }
            }
        }
    }
}
