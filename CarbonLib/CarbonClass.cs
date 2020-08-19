using System;
using System.Collections.Generic;

namespace CarbonLib
{
    public static class Helpers
    {
        public static bool RandomChance(float percent)
        {
            var random = new Random();
            var num = random.Next(0, 101);
            return (num <= percent * 100);
        }

        public static T SelectRandom<T>(this List<T> list)
        {
            var random = new Random();
            return list[random.Next(0, list.Count)];
        }

        public static string MergeListUsingComma<T>(this List<T> listOfObjects) //Lets you say List.MergeListUsingComma 
        {
            return string.Join(", ", listOfObjects);
        }
        
        public static double Scale(double value, double inMin, double inMax, double outMin, double outMax)
        {
            //Lets map the first range to one starting at zero
            var newInValue = value - inMin;
            var newInMax = inMax - inMin;

            //Lets map the Output range to one starting at zero
            var newOutMax = outMax - outMin;

            var scalar = newInValue / newInMax; //Ratio of Value to max
            var scaledValue = newOutMax * scalar; //Apply scaler to max
            var correctedValue = scaledValue + outMin; //Remap the value to one matching the orig
            return correctedValue;
        }

        public static double Clamp(this double value, double max, double min)
        {
            return value > max ? max : value < min ? min : value;
        }
        
    }
}