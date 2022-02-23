//https://judge.softuni.bg/Contests/Practice/Index/518#1

using System;

namespace _02._Magic_Dates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            short startYear = short.Parse(Console.ReadLine());
            short endYear = short.Parse(Console.ReadLine());
            short magicNum = short.Parse(Console.ReadLine());
            string output = "Empty";
            for (short year = startYear; year <= endYear; year++)
            {
                int sumYearDigits = (year % 10) + (year / 10 % 10) + (year / 100 % 10) + (year / 1000);
                for (byte month = 1; month <= 12; month++)
                {
                    byte monthLength;
                    switch (month)
                    {
                        case 2:
                            monthLength = 28;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            monthLength = 30;
                            break;
                        default:
                            monthLength = 31;
                            break;
                    }
                    if (year % 400 != 0 && year % 100 != 0 && year % 4 == 0 && month == 2)
                    {
                        monthLength = 29;
                    }
                    //int monthFirstDigit = month / 10;
                    //int monthSecDigit = month % 10;
                    for (byte date = 1; date <= monthLength; date++)
                    {
                        //int dateFirstDigit = date / 10;
                        //int dateSecDigit = date % 10;
                        //int sumDDMMDigits = (date / 10) + (date % 10) + (month / 10) + (month % 10);
                        int dateWeight = date / 10 * (date % 10 + month / 10 + month % 10 + sumYearDigits)
                            + date % 10 * (month / 10 + month % 10 + sumYearDigits)
                            + month / 10 * (month % 10 + sumYearDigits)
                            + month % 10 * sumYearDigits
                            + year % 10 * (sumYearDigits - year % 10)
                            + year / 10 % 10 * (year / 100 % 10 + year/1000)
                            + year / 100 % 10 * (year / 1000);
                        /*
                        if (month == 3 && date == 17)
                        {
                            Console.WriteLine($"{dateWeight} - {sumDDMMDigits} - {sumYearDigits} - " +
                                $"{monthLength} - {date/10} - {date%10} - {month/10} - {month%10} - " +
                                $"{year/1000} - {year/100%10} - {year/10%10} - {year%10}");
                        }
                        */
                        if (dateWeight == magicNum)
                        {
                            output = string.Format($"{date/10}{date%10}-{month/10}{month%10}-" +
                                $"{year/1000}{year/100%10}{year/10%10}{year%10}");
                            Console.WriteLine(output);
                        }
                    }
                }
            }
            if (output == "Empty")
            {
                Console.WriteLine("No");
            }
        }
    }
}