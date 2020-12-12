using System;
namespace StructureAlgorithms.Algorithms
{
    public static class Sort
    {
        private static T GetMin<T>(T[] array) where T: IComparable
        {
            T min = array[0];
            for (int i = 0; i < array.Length; i++ )
            {
                if(array[i].CompareTo(min) < 1)
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static int GetIndex<T>(T[] array, T  num) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(num) > 1)
                {
                    return i;
                }
            }
            return -1;
        }

        private static T[] RemoveElement<T>(T[] array, T num) where T  : IComparable
        {
            T[] mas = new T[array.Length - 1];
            bool check = false;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(num) &&  !check)
                {
                    check = true;
                 
                }
                else
                {
                    mas[index] = array[i];
                    index++;
                }
            }
            if (check)
            {
                return mas;
            }
            else
            {
                return array;
            }
        }

        public static T[] SelectingSort<T>(T[] array) where T : IComparable
        {
            T[] mas = new T[array.Length];
            int index = 0;
            int max = array.Length -  1;
            int len = array.Length;
            while (index < len)
            {
                mas[index] = GetMin(array);
                var newArray = RemoveElement(array, mas[index]);
                array = newArray;
                index++;
                max--;
            }

            return mas;
        }
            
        public static int partition<T>(T[] array, int start, int finish) where T : IComparable
        {
            int i = start;
            for (int j = start; j <= finish; j++)         
            {
                if (array[j].CompareTo(array[finish]) <= 0)  
                {
                    T t = array[i];                  
                    array[i] = array[j];               
                    array[j] = t;                   
                    i++;                         
                }
            }
            return i - 1;                       
        }


        public static void QuickSort<T>(T[] array, int start, int finish) where T : IComparable
        {
            if (start  >= finish)
            {
                return ;
            }
            else
            {
                var element = partition(array, start, finish);
                QuickSort(array, start,  element - 1);
                QuickSort(array, element + 1,  finish);

            }
        }


    }
}
