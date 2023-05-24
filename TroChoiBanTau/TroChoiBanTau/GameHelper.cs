using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroChoiBanTau
{
    class GameHelper
    {
        private static readonly String alphabet = "abcdefg";
        private int gridLength = 7;
        private static int gridSize = 49;
        private int[] grid = new int[gridSize];
        private int shipcout = 0;

        public String getUserInput(String promt)
        {
            String inputLine = null;
            Console.WriteLine(promt + " ");
            try
            {
                inputLine = Console.ReadLine();
                if (inputLine.Length == 0) return null;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine("IOException" + ex);
                throw;
            }
            return inputLine.ToLower();
        }

        public ArrayList placeShip(int size)
        {
            Random random = new Random();
            ArrayList alphaCells = new  ArrayList();
            String[] alphacoords = new String[size];
            String temp = null;
            int[] coords = new int[size];
            int attempts = 0;
            bool susscess = false;
            int location = 0;
            shipcout++;
            int incr = 1;
            if ((shipcout % 2) == 1)
            {
                incr = gridLength;
            }
            while (!susscess & attempts++ < 200)
            {
                location = (int)(random.Next(0,49));
                int x = 0;
                susscess = true;
                while (susscess && x < size)
                {
                    if (grid[location] == 0)
                    {
                        coords[x++] = location;
                        location += incr;
                        if (location >= gridSize)
                        {
                            susscess = false;
                        }
                        if (x > 0 & (location % gridLength == 0))
                        {
                            susscess = false;
                        }
                    }
                    else
                    {
                        susscess = false;
                    }
                }

            }
            int x1 = 0;
            int row = 0;
            int column = 0;
            while (x1 < size)
            {
                grid[coords[x1]] = 1;
                row = (int)(coords[x1] / gridLength);
                column = coords[x1] % gridLength;
                string str = Convert.ToString(column);
                temp = Convert.ToString(alphabet.ElementAt(column));
                string strinrow = Convert.ToString(row);
                alphaCells.Add(strinrow);
                x1++;
            }
            return alphaCells;
        }

    }
}
