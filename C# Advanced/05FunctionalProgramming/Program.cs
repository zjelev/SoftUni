using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncProg
{
    class Program2
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                //.Select(n => $"Sir {n}")
                .ToList();
            
            names = MySelect(names, n => $"Sir {n}"); 

            Action<string[]> printNames = a => 
             Console.WriteLine(string.Join(Environment.NewLine, a));

            printNames(names.ToArray());
        }

        static List<string> MySelect(List<string> items, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in items)
            {
                string newItem = func(item);
                newList.Add(newItem);
            }

            return newList;
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            Func<int[], int> minNum = nums =>
            {
                int min = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            };

            Console.WriteLine(minNum(numbers));
        }

        static int GetMin(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }

        return min;
        }

        static List<string> MySelect(List<string> items, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in items)
            {
                string newItem = func(item);
                newList.Add(newItem);
            }

            return newList;
        }
    }
    
    class Program4
    {
        /*Find Evens or Odds
You are given a lower and an upper bound for a range of integer numbers. Then a command specifies if you need to
list all even or odd numbers in the given range. Use Predicate<T>. */
        static void Main(string[] args)
        {
            int[] ranges = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int start = ranges[0];
            int end = ranges[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateList = (begin, finish) => // in .NET 2.1 - error
            {
                List<int> nums = new List<int>();

                for (int i = begin; i <= finish ; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateList(start, end);

            Predicate<int> predicate = n => n % 2 == 0;
            //Func<int, bool> evenPredicate = n => n % 2 == 0;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            numbers = MyWhere(numbers, predicate);
            
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> res = new List<int>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    res.Add(item);
                }
            }
            return res;
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunc = x => ++x;
            Func<int, int> multFunc = x => x * 2;
            Func<int, int> subtractFunc = x => --x;
            Action<int[]> printFunc = x => Console.WriteLine(string.Join(" ", x));
            
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        // numbers = numbers.Select(x => addFunc(x)).ToList();
                        numbers = numbers.Select(addFunc).ToList();
                        // numbers = numbers.Select(x => x + 1).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multFunc).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractFunc).ToList();
                        break;
                    case "print":
                        printFunc(numbers.ToArray());
                        break;
                }
            }
        }
    }
    class Program6
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverseList = x =>
            {
                List<int> temp = new List<int>();

                for (int i = x.Count - 1; i >= 0; i--)
                {
                    temp.Add(x[i]);
                }
                return temp;
            };
          
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());
            Func<int, bool> predicate = x => x % n != 0; 
            
            numbers = reverseList(numbers);
            numbers = numbers.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    class Program7
    {
        static void Main(string[] args)
        {
            Func<string, int, string> isLessChars = (x, i) => 
            {
                if(x.Length <= i)
                {
                    return x;
                }
                else
                {
                    return string.Empty;
                }
            };
            
            int n = int.Parse(Console.ReadLine());

            string[] names = Console
                .ReadLine()
                .Split(" ");
            
            names = names.Select(x => isLessChars(x, n)).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }

class Program8
/*Custom Comparator
Write a custom comparator that sorts all even numbers before all the odd ones in ascending order. Pass it to
Array.Sort() function and print the result. Use functions. 
1 2 3 4 5 6 -> 2 4 6 1 3 5 */
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            
            //Array.Sort(numbers, (x, y) => y - x);
            
            //y.CompareTo(x));
            
            Array.Sort(numbers, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return x - y;
                }
            });
            

            //Array.Sort(numbers, (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 : (x % 2 != 0 && y % 2 == 0) ? 1 : x - y);

            Array.Sort(numbers, (x, y) => Math.Abs(x % 2) - Math.Abs(y % 2));
 
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    /*
    11. Party Reservation Filter Module
    You need to implement a filtering module to a party reservation software. First, to the Party Reservation Filter
    Module (PRFM for short) is passed a list with invitations. Next the PRFM receives a sequence of commands that
    specify whether you need to add or remove a given filter.
    Each PRFM command is in the given format:
    &quot;{command;filter type;filter parameter}&quot;
    You can receive the following PRFM commands:
     &quot;Add filter&quot;
     &quot;Remove filter&quot;
     &quot;Print&quot;
    The possible PRFM filter types are:
     &quot;Starts with&quot;
     &quot;Ends with&quot;
     &quot;Length&quot;
     &quot;Contains&quot;
    All PRFM filter parameters will be a string (or an integer only for the &quot;Length&quot; filter). Each command will be valid
    e.g. you won’t be asked to remove a non-existent filter. The input will end with a &quot;Print&quot; command, after which you
    should print all the party-goers that are left after the filtration. See the examples below:
    Examples

    Input Output

    Pesho Misho Slav
    Add filter;Starts with;P
    Add filter;Starts with;M
    Print

    Slav

    Pesho Misho Jica
    Add filter;Starts with;P
    Add filter;Starts with;M
    Remove filter;Starts with;M
    Print

    Misho Jica
    */
    class Program11
    {
        static void Main(string args)
        {
            List<string> people = Console.ReadLine()
                .Split()
                .ToList();
            
            string input;
            List<string> filters = new List<string>();

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(";");
                string command = tokens[0];
                string filter = tokens[1];
                string argument = tokens[2];
                
                if(command == "Add filter")
                {
                    filters.Add($"{filter};{argument}");
                }
                else if (command == "Remove filter")
                {
                    filters.Add($"{filter};{argument}");                    
                }
            }

            foreach (var filterLine in filters)
            {
                var tokens = filterLine.Split(";");
                var filterType = tokens[0];
                var argument = tokens[1];

                switch(filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;   
                    default:
                        break;
                }
            }
        }
    }

}