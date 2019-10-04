using System;
namespace MVA_Class_Demo
{
    public class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;
        public Customer()
        {
        }

        public int TotalPoints { get => totalPoints; }

        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}
