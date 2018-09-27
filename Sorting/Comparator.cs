using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public struct Player
    {
        public int score;
        public string name;
    };

    class Comparator
    {
        static int comparator(Player a, Player b)
        {
            if (a.score > b.score)
            {
                return 1;
            }
            else if (a.score < b.score)
            {
                return -1;
            }
            else if (a.score == b.score)
            {
                if (string.Compare(a.name, b.name) < 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
