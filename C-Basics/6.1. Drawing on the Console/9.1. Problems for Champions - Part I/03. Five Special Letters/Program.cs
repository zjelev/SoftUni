using System;

namespace _03._Five_Special_Letters
{
    class FiveSpecialLetters
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            bool results = false;
            //
             for (char c1 = 'a'; c1 <= 'e'; c1++)
             {
                 for (char c2 = 'a'; c2 <= 'e'; c2++)
                 {
                     for (char c3 = 'a'; c3 <= 'e'; c3++)
                     {
                         for (char c4 = 'a'; c4 <= 'e'; c4++)
                         {
                             for (char c5 = 'a'; c5 <= 'e'; c5++)
                             {
                                string fullword = "" + c1 + c2 + c3 + c4 + c5 + " ";
                                string word = fullword[0].ToString();
                                for (int i = 0; i <= 4; i++)
                                {
                                    if (word.IndexOf(fullword[i]) == -1)
                                    {
                                        word += fullword[i];
                                    }
                                }

                                int multiplier = 0;
                                int weight = 0;
                                for (int i = 0; i < word.Length; i++)
                                {
                                    switch (word[i])
                                    {
                                        case 'a':
                                            multiplier = 5;
                                            break;
                                        case 'b':
                                            multiplier = -12;
                                            break;
                                        case 'c':
                                            multiplier = 47;
                                            break;
                                        case 'd':
                                            multiplier = 7;
                                            break;
                                        case 'e':
                                            multiplier = -32;
                                            break;
                                        default:
                                            break;
                                    }
                                    weight += multiplier * (i + 1);
                                }
                                if ((weight >= begin) && (weight <= end))
                                    {
                                        Console.Write(fullword);
                                    results = true;
                                    }
                                //
                                //Console.WriteLine(fullword);
                                /*if (word == "bcead")
                                {
                                    Console.WriteLine(word);
                                }*/
                                
                                 //Console.WriteLine(weight);
                                 //num++;
                             }
                         }
                     }
                    //
                    //Console.WriteLine(num);
                 }
             }
            if (!results)
            {
                Console.WriteLine("No");
            }
        }
     }
 }
 /*
            //test weight
            string word = "bdcea";
            int multiplier = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        multiplier = 5;
                        break;
                    case 'b':
                        multiplier = -12;
                        break;
                    case 'c':
                        multiplier = 47;
                        break;
                    case 'd':
                        multiplier = 7;
                        break;
                    case 'e':
                        multiplier = -32;
                        break;
                    default:
                        break;
                }
                weight += multiplier * (i + 1);
            }
            Console.WriteLine(weight);
        }
    }
}*/