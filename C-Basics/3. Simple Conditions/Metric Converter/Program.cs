using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string m = "m", mm = "mm", cm = "cm", km = "km",
            //mi = "mi", inch = "in", ft = "ft", yd = "yd", end = "end";
            string inputMeter = "", outputMeter = "";
            double sum = double.Parse(Console.ReadLine());
            double result = 0;
            while ((inputMeter = Console.ReadLine().ToLower()) != "end")
            {
                outputMeter = Console.ReadLine().ToLower();
                if (inputMeter == "m")
                {
                    if (outputMeter == "mm")
                    {
                        result = sum * 1000;
                    }
                    else if (outputMeter == "cm")
                    {
                        result = sum * 100;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum * 0.000621371192;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum * 39.3700787;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum * 0.001;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum * 3.2808399;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum * 1.0936133;
                    }
                    else if ("m" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                
                else if ("mm" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 1000;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum / 10;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum * 0.000621371192 / 1000;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum * 39.3700787 / 1000;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum * 0.001 / 1000;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum * 3.2808399 / 1000;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum * 1.0936133 / 1000;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                
                else if ("cm" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 100;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum * 10;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum * 0.000621371192 / 100;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum * 39.3700787 / 100;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum * 0.001 / 100;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum * 3.2808399 / 100;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum * 1.0936133 / 100;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                
                else if ("km" == inputMeter)
                {
                    if ("mm" == outputMeter)
                    {
                        result = sum * 1000000;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum * 100000;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum * 0.000621371192 * 1000;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum * 39.3700787 * 1000;
                    }
                    else if ("m" == outputMeter)
                    {
                        result = sum / 0.001;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum * 3.2808399 * 1000;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum * 1.0936133 * 1000;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                
                else if ("mi" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 0.000621371192;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 100;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 1000;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 39.3700787;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 0.001;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 3.2808399;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum / 0.000621371192 * 1.0936133;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                else if ("inch" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 39.3700787;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum / 39.3700787 * 100;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum / 39.3700787 * 1000;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum / 39.3700787 * 0.000621371192;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum / 39.3700787 * 0.001;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum / 39.3700787 * 3.2808399;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum / 39.3700787 * 1.0936133;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                else if ("ft" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 3.2808399;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum / 3.2808399 * 100;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum / 3.2808399 * 1000;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum / 3.2808399 * 0.000621371192;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum / 3.2808399 * 0.001;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum / 3.2808399 * 39.3700787;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum / 3.2808399 * 1.0936133;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
                else if ("yd" == inputMeter)
                {
                    if ("m" == outputMeter)
                    {
                        result = sum / 1.0936133;
                    }
                    else if ("cm" == outputMeter)
                    {
                        result = sum / 1.0936133 * 100;
                    }
                    else if ("mm" == outputMeter)
                    {
                        result = sum / 1.0936133 * 1000;
                    }
                    else if ("mi" == outputMeter)
                    {
                        result = sum / 1.0936133 * 0.000621371192;
                    }
                    else if ("km" == outputMeter)
                    {
                        result = sum / 1.0936133 * 0.001;
                    }
                    else if ("inch" == outputMeter)
                    {
                        result = sum / 1.0936133 * 39.3700787;
                    }
                    else if ("ft" == outputMeter)
                    {
                        result = sum / 1.0936133 * 3.2808399;
                    }
                    else if ("yd" == outputMeter)
                    {
                        result = sum;
                    }
                    Console.WriteLine(result);
                }
            }
            
        }
    }
}