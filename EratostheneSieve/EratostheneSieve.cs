using System;
using System.Linq;

namespace EratostheneSieve
{
    public class Sieve
    {
        public static int[] Compute(int ceil)
        {
            int i, j;
            bool[] A;
            int[] results;

            if(ceil < 2)
            {
                results = new int[0];
            }
            else
            {
                A = (from n in Enumerable.Range(0, ceil) select true).ToArray();
                for (i = 2; i < Math.Sqrt((double) ceil); i++)
                {
                    if(A[i])
                    {
                        for(j = (i*i); j < ceil; j+=i)
                        {
                            A[j] = false;
                        }
                    }
                }
                results = (from n in Enumerable.Range(1, ceil - 1) where A[n] select n).ToArray();
            }

            return results;
        }
    }
}
