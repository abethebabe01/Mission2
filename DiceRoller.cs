using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class DiceResults
{
    public int[] SimulateRolls(int numberOfRolls)
    {
        Random random = new Random();
        int[] results = new int[13]; // Indices 2 through 12 represent possible dice combinations

        for (int i = 0; i < numberOfRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
