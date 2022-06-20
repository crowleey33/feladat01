using System;

namespace Feladat01
{
    class Feladat01
    {
        static void Main(string[] args)
        {
            string[] szinek = { "piros", "kék", "zöld", "sárga", "fekete" };  // INPUT                  

            int output = feladat01(szinek);   //OUTPUT
        }

        static int feladat01(string[] szinek)
        {
            int db = szinek.Length;
            int k = db;
            int eredmeny = 0;

            if (db <= 1)
            {
                return 0;
            }
            else
            {
                while (k > 1)
                {
                    eredmeny += Faktorialis(db) / (Faktorialis(k) * Faktorialis(db - k));
                    k--;
                }
            }
            return eredmeny;
        }

        static int Faktorialis(int faktorialis)
        {
            int eredmeny = 1;

            while (faktorialis >= 1)
            {
                eredmeny *= faktorialis;
                faktorialis--;
            }
            return eredmeny;
        }
    }
}
