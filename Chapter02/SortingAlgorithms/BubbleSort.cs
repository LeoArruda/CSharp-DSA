namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }
                if (!isAnyChange)
                {
                    break;
                }
            }
        }

        private static void Swap<T>(T[] array, int firstIndex, int secondIndex)
        {
            T temporary = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temporary;
        }

    }
}
