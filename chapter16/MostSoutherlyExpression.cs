/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System.Collections.Generic;

namespace Chapter16
{
    public class MostSoutherlyExpression : IExpression
    {
        private IList<IExpression> expressions;

        public MostSoutherlyExpression(IList<IExpression> expressions)
        {
            this.expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultingCity = new City("Nowhere", 999.9, 999.9);
            foreach (IExpression currentExpression in expressions)
            {
                City currentCity = currentExpression.Interpret();
                if (currentCity.Latitude < resultingCity.Latitude)
                {
                    resultingCity = currentCity;
                }
            }
            return resultingCity;
        }

    }
}
