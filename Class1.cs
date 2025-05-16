using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    class Arr
    {
        private char[,] _array;
        public Arr(char[,] array) 
        { 
            _array = array;
        }

        public void SetValue(int line, int column, char value)
        {
            _array[line,column] = value;
        }

        public char GetValue(int line, int column) 
        {
            return _array[line, column];
        }

        public int getLength() { return _array.Length; }


        public string this[int row]
        {
            get 
            {
                int columns = _array.GetLength(1);
                string result = "";
                for (int n = 0; n < columns; n++)
                {
                    result += _array[row, n];
                }
                return result;
            }

        }

        public int ConsonantCount
        {
            get
            {
                int counter = 0;
                string vowels = "aeioquy";

                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int n = 0; n < _array.GetLength(1); n++)
                    {
                        char ch = Char.ToLower(_array[i, n]);
                        if (!vowels.Contains(ch) && Char.IsLetter(ch))
                        {
                            counter++;
                        }
                    }
                }

                return counter;
            }
        }

    } 
}
