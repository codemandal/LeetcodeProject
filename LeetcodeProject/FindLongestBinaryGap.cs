using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public  static class FindLongestBinaryGap
    {
        public static int FindGap(int N)
        {
            int gap = 0;
            string binary = "";
            bool startCounting = false;
            string prevBit = "";
            int prevSum = 0;
            while (N > 0)
            {
                var bit = retBinary(N);
                binary = bit + binary;
                N = N/2;
                if (prevBit == "1" && startCounting == false)
                    startCounting = true;

                if (startCounting)
                {

                    if (bit == "1")
                    {
                                                
                        startCounting = false;
                        prevSum = gap;
                        gap = 0;                     

                    }
                    else
                    {
                        gap++;
                    }
                }                               
                prevBit = bit;
              
            }
           
            return (prevSum > gap)? prevSum : gap;
        }

        public static string retBinary(int N)
        {
            return (N % 2).ToString(); 
        }
    }
}
