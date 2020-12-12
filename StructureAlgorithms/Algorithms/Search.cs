using System;

namespace StructureAlgorithms.Algorithms
{
    public static class Search

    {
        public static int? binarySearch<T>(T[] list, T element ) where T : IComparable
        {
            int min = 0;
            int max = list.Length;
            int middle;
            while (min!=max)
            {
                middle = (max + min) / 2;
                if (list[middle].CompareTo(element) == 0) return middle;
                if  (list[middle].CompareTo(element) > 0)
                {
                    max -= 1;
                } else
                {
                    min += 1;
                }

            }
            return null;

        }
    }
}
