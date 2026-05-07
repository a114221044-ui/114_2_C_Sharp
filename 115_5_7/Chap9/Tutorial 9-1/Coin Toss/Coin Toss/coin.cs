using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class coin
    {
        private string sideUp;

        public coin()
        {
            sideUp = "Head";
        }

        public void toss()
        {
            Random random = new Random();
            int tossResult = random.Next(0, 2); // 0 or 1
            if (tossResult == 0)
            {
                sideUp = "Head";
            }
            else
            {
                sideUp = "Tail";
            }
        }

        public string getSideUp()
        {
            return sideUp;
        }
    }
}
