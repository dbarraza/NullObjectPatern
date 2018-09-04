using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1  = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Player 1"
            };
            var player2 = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Player 2"
            };
            var player3 = new PlayerCharacter(SpecialDefence.NullObject)
            {
                Name = "Player 3"
            };

            player1.Hit(10);
            player2.Hit(10);
            player3.Hit(10);
        }
    }
}
