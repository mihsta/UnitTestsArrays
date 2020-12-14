using System;

namespace MainModule
{
    public static class ArrayManager
    {
        public static int FindMax(int[] a)
        {
            
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        public static double GetSrednee(int[] a)
        {
        int sum = 0;
        for (int i = 0; i<a.Length; i++)
            {
               sum +=a[i];
            }
            return (double)sum / a.Length;
        }
    }
}
