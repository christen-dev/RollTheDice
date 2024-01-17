using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice;

internal class RollIt
{
    // Create a Random object
    Random random = new Random();

    //Initialize Dice
    int dice1 = 0;
    int dice2 = 0;
    int diceTotal = 0;

    //Initalize Combination Array
    int[] NumRolled = new int[11];


    public int[] Roll(int numOfRolls)
    {
        for (int i = 0; i < numOfRolls; i++)
        {
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            diceTotal = (dice1 + dice2);

            NumRolled[(diceTotal - 2)]++;
        }

        return NumRolled;
    }
}


