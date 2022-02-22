using System;
using System.Collections.Generic;
using System.Linq;

namespace aleatorio
{
    static public class ListRandom
    {
        static Random nRand = new Random();
        internal static List<int> Rand(int nElement, int minValue = 1, int maxValue = 100)
        {
            
            List<int> listNum = new List<int>();

            for(int i = 0; i < nElement; i++)
            {
                listNum.Add(nRand.Next(minValue, maxValue));
            }

            return listNum;
        }

        internal static List<int> RandNoRepeat(int nElement, int minValue = 1, int maxValue = 100)
        {
            List<int> allValues = new List<int>();
            List<int> listRand = new List<int>();
            
            int iRand;

            for(int i= minValue; i < maxValue; i++)
            {
                allValues.Add(i);
            }

            for(int i = 0; i < nElement; i++)
            {
                iRand = nRand.Next(0, allValues.Count);
                listRand.Add(allValues[iRand]);
                allValues.RemoveAt(iRand);
            }

            return listRand;
        }



        internal static string ConvertToString(List<int> listNum)
        {
            string sequencia = "";

            foreach(var num in listNum)
            {
                sequencia += num + " ";
            }

            return sequencia;
        }
    }
}