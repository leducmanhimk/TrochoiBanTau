using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroChoiBanTau
{
    class Ship  
    {
        
        private ArrayList locationCells;
        private String name;

        
        public ArrayList LocationCells { get => locationCells; set => locationCells = value; }
        public string Name { get => name; set => name = value; }

        public string check(String userinput)
        {
            string result = "miss";
            int index = locationCells.IndexOf(userinput);
            if (index > 0)
            {
                locationCells.Remove(index);
                if (locationCells.Count <= 0)
                {
                    result = "kill";

                }
                else result = "hit";
            }
            return result;
        }

        public void setLocationCells(ArrayList loc)
        {
            locationCells = loc;
            locationCells.Sort();
        }

       
    }
}
