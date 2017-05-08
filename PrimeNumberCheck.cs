using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberUtility
{
    public class PrimeNumberCheck
    {
        public PrimeNumberCheck() { }

        public bool IsPrime(ulong numberToCheck)
        {
            ulong squareRoot = 0;

            // Get the square root of the passed in value.
            squareRoot = (ulong)Math.Sqrt((double)numberToCheck);

            if (numberToCheck < 2)
            {
                return false;
            }

            // Two is the only even prime.
            if (numberToCheck == 2)
            {
                return true;
            }

            if (IsEven(numberToCheck) == true)
            {
                return false;
            }

            for (ulong x = 3; x <= squareRoot; x += 2)
            {
                if (numberToCheck % x == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPrime(int numberToCheck)
        {
            int squareRoot = 0;

            // Get the square root of the passed in value.
            squareRoot = (int)Math.Sqrt((double)numberToCheck);

            if (numberToCheck < 2)
            {
                return false;
            }

            // Two is the only even prime.
            if (numberToCheck == 2)
            {
                return true;
            }

            if (IsEven(numberToCheck) == true)
            {
                return false;
            }

            for (int x = 3; x <= squareRoot; x += 2)
            {
                if (numberToCheck % x == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsEven(int numberToCheck)
        {
            bool isEven = false;

            if (numberToCheck % 2 == 0)
            {
                isEven = true;

            }

            return isEven;
        }

        private bool IsEven(ulong numberToCheck)
        {
            bool isEven = false;

            if(numberToCheck % 2 == 0)
            {
                isEven = true;

            }

            return isEven;
        }
    }
}
