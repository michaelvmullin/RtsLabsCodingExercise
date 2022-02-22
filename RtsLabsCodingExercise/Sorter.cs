using System;

namespace RtsLabsCodingExercise
{
    /// <summary>
    /// Class to sort numbers and rotate text.
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// Sorts a specified list of integers as above or below a specified value.
        /// </summary>
        /// <param name="unsortedIntegers">The list of integers to sort</param>
        /// <param name="comparisonValue">The value by which to compare the list of integers</param>
        /// <returns>A dictionary containing the number of integers above and number of integers below</returns>
        public Dictionary<string, int> AboveBelow(List<int> unsortedIntegers, int comparisonValue)
        {
            int above = 0;
            int below = 0;

            for(int i = 0; i < unsortedIntegers.Count; i++)
            {
                // Ignore values that are equal
                if (unsortedIntegers[i] > comparisonValue)
                {
                    above++;
                } else if(unsortedIntegers[i] < comparisonValue)
                {
                    below++;
                }
            }

            Dictionary<string, int> sortedIntegers = new Dictionary<string, int>()
            {
                { "above", above },
                { "below", below }
            };

            return sortedIntegers;
        }

        /// <summary>
        /// Rotates forward the specified string by the specified number of characters
        /// </summary>
        /// <param name="originalString">The string to rotate</param>
        /// <param name="rotationAmount">The number of characters to rotate</param>
        /// <returns>The rotated string</returns>
        public string StringRotation(string originalString, uint rotationAmount)
        {
            // Account for full rotations.
            if(rotationAmount > originalString.Length)
            {
                rotationAmount = rotationAmount % (uint)originalString.Length;
            }

            int splitIndex = (int)(originalString.Length - rotationAmount);
            string rotatedChars = originalString.Substring(0, splitIndex);
            string rotatedString = originalString.Remove(0, splitIndex);
            rotatedString += rotatedChars;

            return rotatedString;
        }
    }
}
