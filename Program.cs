using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[] {9,9,9};
            Console.WriteLine(Parser.LastDigit(array));
        }


    }


        public class Parser
        {
        public static int LastDigit(int[] array)
        {
            int LastDigit = 0;
            BigInteger[] arr = new BigInteger[array.Length];
            BigInteger Powresult = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }
            Powresult = Pow(arr[arr.Length - 2], arr[arr.Length-1]);
            for (int i = arr.Length-1; i > 1; i--)
            {
                Powresult = Pow(arr[i - 2],Powresult);
            }
            //Console.WriteLine(Powresult);
            LastDigit =(Int32)Powresult % 10;
            return LastDigit;
        }
        public static BigInteger Pow(BigInteger value,BigInteger exponent)
        {
            BigInteger temp = value;
            for (int i = 0; i < exponent-1; i++)
            {
                temp = BigInteger.Multiply(temp, value);
            }
            value = temp;
            return value;
        }
    }

    
}



