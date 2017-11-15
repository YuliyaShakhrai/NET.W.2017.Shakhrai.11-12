using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public class BinarySearching
    {
        /// <summary>
        /// Method that realized binary search.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="element">Element.</param>
        /// <param name="comparer">Comparer.</param>
        public static int BinarySearch<T>(T[] array, T element, IComparer<T> comparer = null)
        {
            VerifyArray(array);
            if (ReferenceEquals(comparer, null))
            {
                comparer = Comparer<T>.Default;
            }

            if (comparer.Compare(element, array[0]) < 0 || comparer.Compare(element, array[array.Length - 1]) > 0)
            {
                return -1;
            }

            int start = 0;
            int finish = array.Length - 1;
            int middle;

            while (start < finish)
            {
                middle = (start + finish) / 2;

                if (comparer.Compare(element, array[middle]) == 0)
                {
                    return middle;
                }
                else if (comparer.Compare(element, array[middle]) < 0)
                {
                    finish = middle;
                }
                else
                {
                    start = middle + 1;
                }
            }

            return (comparer.Compare(array[finish], element) == 0) ? finish : -1;
        }

        /// <summary>
        /// Verification of input array.
        /// </summary>
        /// <param name="array">Array.</param>
        private static void VerifyArray<T>(T[] array)
        {
            if (ReferenceEquals(array, null))
            {
                throw new ArgumentNullException($"{nameof(array)} is null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"{nameof(array)} is empty.");
            }
        }
    }
}
