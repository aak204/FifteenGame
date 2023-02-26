using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FifteenGUI
{
    internal class Game
    {
        private int[,] field;
        private int size;
        private int x0, y0;

        Random rand = new Random();
        public Game(int size)
        {
            this.size = size;
            field = new int[size, size];
        }

        private int CoordinatesToPosition(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return (y * size) + x;
        }
        private void PositionToCoordinates(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }
        public void Start()
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    field[x, y] = CoordinatesToPosition(x, y) + 1;
                }
            }
            x0 = size - 1;
            y0 = size - 1;
            field[x0, y0] = 0;
        }

        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (x < 0 || x >= size || y < 0 || y >= size)
            {
                return 0;
            }
            return field[x, y];
        }

        public void Shift(int position)
        {
            PositionToCoordinates(position, out int x, out int y);
            //Проверяем является ли ячейка, соответствующая нажатой кнопке, соседней с пустой ячейкой
            if (Math.Abs(x0 - x) + Math.Abs(y0 - y) != 1) return;
            field[x0, y0] = field[x, y];
            field[x, y] = 0;
            x0 = x;
            y0 = y;
        }

        public void ShiftRandom()
        {
            int a = rand.Next(0, 4);
            int x = x0;
            int y = y0;
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }
            Shift(CoordinatesToPosition(x, y));

        }

        public bool Check()
        {
            if (!(x0 == size - 1 && y0 == size - 1)) return false;
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (field[x, y] != CoordinatesToPosition(x, y) + 1) return false;
            return true;
        }
    }
}
