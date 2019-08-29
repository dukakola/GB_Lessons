using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_02
{
    class RandomNumbers
    {
        int RandomNum;
        int CountTry;

        public RandomNumbers(int RandomNum)
        {
            this.RandomNum = RandomNum;
            CountTry = 5;
        }

        public void TryCount()
        {
            CountTry -= 1;
        }

        public void Reset()
        {
            CountTry = 5;
        }

        public int Try
        {
            get
            {
                return CountTry;
            }
        }

        public int Num
        {
            get
            {
                return RandomNum;
            }
        }
    }
}
