using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroChoiBanTau
{
    class SinkaShip
    {
        private GameHelper helper = new GameHelper();
        private ArrayList shiplist = new ArrayList();
        private int numOfGuesses = 0;

        public void setUpGame()
        {
            Ship one = new Ship();
            one.Name = "Endeavour";
            Ship two = new Ship();
            two.Name = "Black Pearl";
            Ship three = new Ship();
            three.Name = "Flying Dutchman";
            shiplist.Add(one);
            shiplist.Add(two);
            shiplist.Add(three);

            Console.WriteLine("Your goal is to sink three ships");
            Console.WriteLine("Endeavour, Black Pearl, Flying Dutchman");
            Console.WriteLine("Try to sink them all in the fewest number of guesses");

            foreach (Ship ship in shiplist)
            {
                ArrayList newlocation = helper.placeShip(3);
                ship.setLocationCells(newlocation);

            }

        }

        public void startGame()
        {
            while (shiplist.Count > 0)
            {
                String userGess = helper.getUserInput("Enter a guess");
                checkUserGuess(userGess);
            }
            finishGame();
        }

        private void checkUserGuess(String userGuess)
        {
            numOfGuesses++;
            String result = "miss";

            foreach (Ship ship  in shiplist)
            {
                result = ship.check(userGuess);
                if (result.Equals("hit"))
                {
                    break;
                }
                if (result.Equals("kill"))
                {
                    shiplist.Remove(ship);
                    break;
                }
            }
            Console.WriteLine(result);
        }

        private void finishGame()
        {
            Console.WriteLine("All the ships are sunk! you are now the king of the sea!");
            if (numOfGuesses <= 18)
            {
                Console.WriteLine("It only took you" + numOfGuesses + "guess");
                Console.WriteLine("You got out before your options sank.");
            }
            else
            {
                Console.WriteLine("Took you long enough." + numOfGuesses + "guess");
                Console.WriteLine("Fish are dancing wiht your options");
            }
        }
    }
}
