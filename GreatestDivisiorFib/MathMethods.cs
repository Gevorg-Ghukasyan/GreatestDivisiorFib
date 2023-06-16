using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestDivisiorFib
{
    internal class MathMethods
    {
       static  public int Fibonacci( int number)
        {
            if(number == 1)
            {
                return 1;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

      

        static public List <int> GetDivisiorList(int number)
        {
            List<int> listDivisor = new List<int>();
     
            if (number == 1)
            {
                listDivisor.Add(1);
                return listDivisor;
            }
            else
            {
               
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        listDivisor.Add(i);
                    }

                }
                listDivisor.Add(number);
                return listDivisor;
            }
        }
        static public  int MyGreatestDivisior(int first, int second)
        {
            List<int> listFirst = GetDivisiorList(first);
            List<int> listSecond = GetDivisiorList(second);
            if (listFirst.Count() == 1 || listSecond.Count() == 1)
            {
                return 1;
            }
            int intersectMax = listFirst.Intersect(listSecond).Max(); // Intersect Վերադարձնում է Համընկնող տարեր
            return intersectMax;
        }
        public static int FindGreatestDivisiorIterative(int first , int second)
        {
            while (second != 0) 
            {
                int reminder = first % second;
                first = second;
                second = reminder;
            }
            return  first;
        }
        public static int FindGreatestDivisiorRecursive(int first, int second)
        {
            if( second == 0)
            {
                return first;
            }
            return FindGreatestDivisiorRecursive(second, first % second);
        }




    }
}
