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
    public class DirectionalEvaluator
    {
        private IDictionary<string, City> cities;

        public DirectionalEvaluator()
		{
            cities = new Dictionary<string, City>();

            cities["aberdeen"] = new City("Aberdeen", 57.15, -2.15);
            cities["belfast"] = new City("Belfast", 54.62, -5.93);
            cities["birmingham"] = new City("Birmingham", 52.42, -1.92);
            cities["dublin"] = new City("Dublin", 53.33, -6.25);
            cities["edinburgh"] = new City("Edinburgh", 55.92, -3.02);
            cities["glasgow"] = new City("Glasgow", 55.83, -4.25);
            cities["london"] = new City("London", 51.53, -0.08);
            cities["liverpool"] = new City("Liverpool", 53.42, -3.0);
            cities["manchester"] = new City("Manchester", 53.5, -2.25);
            cities["southampton"] = new City("Southampton", 50.9, -1.38);
        }

        public virtual City Evaluate(string route)
		{
            // Define the syntax tree
            Stack<IExpression> expressionStack =
									new Stack<IExpression>();

			// Get each separate token
			IList<string> tokens = new List<string>();
			int fromIndex = 0;
			bool finished = false;
			while (!finished)
			{
				int spaceLocation = route.IndexOf(" ", fromIndex);
				if (spaceLocation >= 0)
				{
					tokens.Add(route.Substring(fromIndex,
												spaceLocation - fromIndex));
					fromIndex = spaceLocation + 1;
				}
				else
				{
					tokens.Add(route.Substring(fromIndex));
					finished = true;
				}
			}

            // Parse each token in route string
            foreach (string token in SplitTokens(route))
			{
                // Is token a recognised city?
                if (cities.ContainsKey(token))
				{
                    City city = cities[token];
                    expressionStack.Push(new CityExpression(city));

                // Is token to find most northerly?
                }
				else if (token.Equals("northerly"))
				{
                    expressionStack.Push(new MostNortherlyExpression
										(LoadExpressions(expressionStack)));

                // Is token to find most southerly?
                }
				else if (token.Equals("southerly"))
				{
                    expressionStack.Push(new MostSoutherlyExpression
										(LoadExpressions(expressionStack)));

                // Is token to find most westerly?
                }
				else if (token.Equals("westerly"))
				{
                    expressionStack.Push(new MostWesterlyExpression
										(LoadExpressions(expressionStack)));

                // Is token to find most easterly?
                }
				else if (token.Equals("easterly"))
				{
                    expressionStack.Push(new MostEasterlyExpression
										(LoadExpressions(expressionStack)));
                }
            }

            // Resulting value
            return expressionStack.Pop().Interpret();
        }

		// Get each separate token from a string
		private IList<string> SplitTokens(string str)
		{
			IList<string> tokens = new List<string>();
			int fromIndex = 0;
			bool finished = false;
			while (!finished)
			{
				int spaceLocation = str.IndexOf(" ", fromIndex);
				if (spaceLocation >= 0)
				{
					tokens.Add(str.Substring(fromIndex,
										spaceLocation - fromIndex));
					fromIndex = spaceLocation + 1;
				}
				else
				{
					tokens.Add(str.Substring(fromIndex));
					finished = true;
				}
			}
			return tokens;
		}

        private IList<IExpression> LoadExpressions
							(Stack<IExpression> expressionStack)
		{
            IList<IExpression> expressions = new List<IExpression>();
            while (expressionStack.Count > 0)
			{
                expressions.Add(expressionStack.Pop());
            }
            return expressions;
        }

    }
}
//----------------------------------------------------------------------------------------
//	Copyright © 2007 - 2012 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to replace most calls to the Java String.split method.
//----------------------------------------------------------------------------------------
internal static class StringHelperClass {
	//------------------------------------------------------------------------------------
	//	This method is used to replace most calls to the Java String.split method.
	//------------------------------------------------------------------------------------
	internal static string[] StringSplit(string source, string regexDelimiter, bool trimTrailingEmptyStrings) {
		string[] splitArray = System.Text.RegularExpressions.Regex.Split(source, regexDelimiter);

		if (trimTrailingEmptyStrings) {
			if (splitArray.Length > 1) {
				for (int i = splitArray.Length; i > 0; i--) {
					if (splitArray[i - 1].Length > 0) {
						if (i < splitArray.Length)
							System.Array.Resize(ref splitArray, i);

						break;
					}
				}
			}
		}

		return splitArray;
	}
}
