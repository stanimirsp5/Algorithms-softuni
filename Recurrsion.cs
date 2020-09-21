using System;
namespace AlgorithmsSoftuni
{
    public class Recurrsion
    {
        public Recurrsion()
        {

        }

        public int Factoriel(int n)
        {
            if(n == 0)
            {
                return 1;
            }

            return Factoriel(n-1) * n;
        }
    }
}
