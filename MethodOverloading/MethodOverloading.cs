using System;
namespace MethodOverloading
{
	
    public class MethodOverloading
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isMoney)
        {
            var sum = num1 + num2;
            if (isMoney == true && sum == 1)
            {
                return $"{sum} dollar";

            }
            else if (isMoney == true && sum > 1)
            {
                return $"{sum} dollars ";

            }
            else if (isMoney == true && sum < 1)
            {

                return $"{sum} dollars";
            }
            else
            {
               return ($"{sum}");

            }
        }
    }


}

