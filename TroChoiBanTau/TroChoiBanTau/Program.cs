using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroChoiBanTau
{
    class Program
    {
        static void Main(string[] args)
        {
            SinkaShip GamesinkaShip = new SinkaShip();
            GamesinkaShip.setUpGame();
            GamesinkaShip.startGame();
            Console.ReadKey();
        }
    }
}
