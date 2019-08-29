using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_01
{
    class Doubler
    {
        int CurrentValue;
        int ToGoValue;
        int MoveCount;
        int ReturnValue;

        public Doubler(int ToGoValue)
        {
            this.ToGoValue = ToGoValue;
            CurrentValue = 0;
            MoveCount = 0;
            ReturnValue = 0;
        }

        public void Plus()
        {
            CurrentValue++;
            MoveCount++;
            ReturnValue = CurrentValue - 1;
        }

        public void Multi()
        {
            CurrentValue *= 2;
            MoveCount++;
            ReturnValue = CurrentValue / 2;
        }

        public void Reset()
        {
            CurrentValue = 0;
            MoveCount = 0;
            ReturnValue = 0;
        }

        public int Current
        {
            get
            {
                return CurrentValue;
            }

            set
            {
                CurrentValue = value;
            }
        }

        public int ToGo
        {
            get
            {
                return ToGoValue;
            }
        }

        public int Move
        {
            get
            {
                return MoveCount;
            }
        }

        public int Return
        {
            get
            {
                return ReturnValue;
            }
        }
    }
}
