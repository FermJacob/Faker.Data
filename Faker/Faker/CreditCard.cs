//-----------------------------------------------------------------------
// <copyright file="CreditCard.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Credit card class
    /// </summary>
    public static class CreditCard
    {
        // Credit Card Number (CC Type)
        // Credit Card Expiration
        private static List<string> creditCardType;

        /// <summary>
        /// Gets a random credit card type
        /// </summary>
        /// <returns>string of random credit card</returns>
        public static string CreditCardType()
        {
            if (creditCardType == null)
            {
                creditCardType = XML.GetListString("CreditCardType");
            }

            return creditCardType[Number.RandomNumber(0, creditCardType.Count - 1)];
        }
    }
}
