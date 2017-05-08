using System;

namespace PrimeNumberUtility
{
    public class RandomPrime
    {
        private Random randomNumber;
        private PrimeNumberCheck primeNumberCheck;

        public RandomPrime()
        {
            randomNumber = new Random();
            primeNumberCheck = new PrimeNumberCheck();
        }

        public int Generate()
        {
            int randNum = 0;

            do
            {
                randNum = randomNumber.Next(2, int.MaxValue);
            }
            while (primeNumberCheck.IsPrime(randNum) == false);

            return randNum;
        }
    }
}