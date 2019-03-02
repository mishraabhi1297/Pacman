using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public struct Vector2D
    {
        private int _x, _y;

        public Vector2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
    }

    /// <summary>
    /// The Pacman class holds the attributes of the Pacman (i.e., PositionX, PositionY, Facing)
    /// </summary>
    public class Pacman
    {
        private int _x, _y;
        private String _facing;

        public Pacman(int x, int y, String face)
        {
            _x = x;
            _y = y;
            _facing = face;
        }

        public string Facing
        {
            get => _facing;
            set => _facing = value;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }
    }
}
