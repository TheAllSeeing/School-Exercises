﻿using System;

namespace Recursion
{
    class Program
    {

        static string PrntArr(int[] Arr)
        {
            string ArrString = String.Empty;
            ArrString += "{";
            foreach (int num in Arr)
            {
                ArrString += num + ", ";
            }
            ArrString += "}";

            return ArrString;
        }

        static void Main(string[] args)
        {
            int Result;
            int Number;

            //Pick the exercise:
            while(true)
            {
                Console.WriteLine("Please insert exercise number to run (or \"q\" to quit.)");
                string ExeNum = Console.ReadLine();
                
                if(ExeNum == "q")
                {
                    break;
                }

                switch(ExeNum)
                {
                    case("1"):
                        Console.WriteLine("insert a number ad we will calculate the sum" +
                        "of all numbers between it and 0.");
                        Console.WriteLine($"Result: {Exe1(int.Parse(Console.ReadLine()))}");
                        break;
                    case("2"):
                        Console.WriteLine("Please insert a number and we will print its factorial");
                        Console.WriteLine($"Result: {Factorial(int.Parse(Console.ReadLine()))}");
                        break;
                    case("3"):
                        Console.WriteLine("Please insert a nonnegative integer, "
                        + "and we will print the sum of all odd nnumbers preceding it.");
                        Console.WriteLine($"Result: {Exe3(int.Parse(Console.ReadLine()))}");
                        break;
                    case("4"):
                        Console.WriteLine("Please insert a number, and we will return the amount" + 
                        " of digits it has");
                        Console.WriteLine($"Result: {CountDigits(int.Parse(Console.ReadLine()))}");
                        break;
                    case("5"):
                        Console.WriteLine("This program calculates floor division between " +
                        "two input numbers.\nFirst, please insert the dividend.");
                        int dividend = int.Parse(Console.ReadLine());
                        Console.WriteLine("Now, insert the divisor.");
                        int divisor = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{dividend} // {divisor} = {Divide(dividend, divisor)}");
                        break;
                    case("6"):
                        Console.WriteLine("This program preforms the modolus operation on a "+
                            "a given input.\n Please insert the base number.");
                        Number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Now, please insert the mod: ");
                        int Mod = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Number} % {Mod} = {Modulo(Number,Mod)}");
                        break;
                    case("7"):
                        Console.WriteLine("This program checks wether an integer" +
                        "is cleanly divisable by another integer (their modolu operation return 0");
                        Console.WriteLine("First, please insert the dividend.");
                        int Dividend = int.Parse(Console.ReadLine());
                        Console.WriteLine("Now, please insert the divisor");
                        int Divisor = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Your result: {Divisible(Dividend, Divisor)}");
                        break;
                    case("8"):
                        Console.WriteLine("Please insert a number, and we will check if it's prime.");
                        Number = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{Number} is {(IsPrime(Number) ? "Prime!" : "Not Prime!")}");
                        break;
                    case("9"):
                        Console.WriteLine("Please insert a number, and we will check if its digits" +
                        "share an identical parity.");
                        Console.WriteLine( ParityConsistent(int.Parse(Console.ReadLine())) ?
                         "They do!" : 
                         "They don't!");
                        break;
                    case("10"):
                        Console.WriteLine("Please insert an element, and we will return the sum of"
                        + "all elements in the series the sum of all elements up to it in the"
                        + "series 1*2 + 2^2 + 3*2 + 4^2 ... n*2/n^2 ");
                        Console.WriteLine($"Result: {Exe10(int.Parse(Console.ReadLine()))}");
                        break;
                    case("11"):
                        Console.WriteLine("Please insert an element, and we will return the sum of"
                        + "all elements in the series the sum of all elements up to it in the"
                        + "series 1 + sqrt(3) + 5 - sqrt(7) ... n / sqrt(n) ");
                        Console.WriteLine($"Result: {Exe11(int.Parse(Console.ReadLine()))}");
                        break;
                    case("12"):
                        Console.WriteLine("This program calculates the sum of all intger " +
                        "products of another integer that are smaller than an input number.\n" +
                        "First, please insert the integer");
                        int Base = int.Parse(Console.ReadLine());
                        Console.WriteLine("Now, please insert an integer maximum product. " + 
                            "All products below it will be calculated.");
                        int Max = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The resulting sum: {Exe12(Base, Max)}");
                        break;
                    case("13"):
                        Console.WriteLine("Which Part?");
                        string Part = Console.ReadLine();
                        switch(Part)
                        {
                            case("A"):
                                Console.WriteLine("This program calaculates elements in the series "
                                + "where the first element is 0, the second is 1, and the rest are "
                                + "each the sum of the squares of the two previous\n"
                                + "Please inset the position, and we will calculate the element.");
                                Console.WriteLine($"Your result: {Exe13A(int.Parse(Console.ReadLine()))}");
                                break;
                            case("B"):
                                Console.WriteLine("This program calaculates elements in the series "
                                + "where the first element is 0, the second is 1, and the rest are "
                                + "each the sum of the squares of the two previous\n"
                                + "Please insert the position, and we will calculate the sum up"
                                + "to that position.");
                                Console.WriteLine($"Your result: {Exe13B(int.Parse(Console.ReadLine()))}");
                                break;
                            default:
                                Console.WriteLine("Part not found.");
                                break;
                        }
                        break;
                    case("14"):
                        Console.WriteLine("This is a program which takes in an array, and sums "
                        + "it up to a given index. In this example, we will use the array "
                        + "[0, 6, 3, 3, 7, 8, 12, -4]\nNow, please insert the 0-based index.");
                        Result = SumUpTo(new int[] {0, 6, 3, 3, 7, 8, 12, -4}, 
                            int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Your result: {Result}");
                        break;
                    case("15"):
                        Console.WriteLine("This is a program which takes in an array, and counts "
                        + "how many positive numbers it has up to a given index. In this example, "
                        + "we will use the array [0, -6, -3, 3, 7, -8, 12, 4]\n"
                        + "Now, please insert the 0-based index.");
                        Result = CountPositives(new int[] {0, -6, -3, 3, 7, -8, 12, 4}, 
                            int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Your result: {Result}");
                        break;
                    case("16"):
                        Console.WriteLine("This program finds position of an element in an array, "
                        + "or returns -1 if it's not there. For this example, we will use the "
                        + "array [0, 6, 3, -3, 7, 8, 12, -4].\n Now, please insert the element:");
                        int Element = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Your position: "
                        + $"{IndexOf(new int[] {0, 6, 3, -3, 7, 8, 12, -4}, Element)}");
                        break;
                    case("17"):
                        Console.WriteLine("This Program checks if an array is sorted. We will test it"
                        + "with two arrays: [0, 6, 3, -3, 7, 8, 12, -4] and its sorted version "
                        + "([-4, -3, 0, 3, 6, 7, 8, 12]).");
                        Console.WriteLine($"Unsorted: {IsSorted(new int[] {0, 6, 3, -3, 7, 8, 12, -4})}\n"
                        + $"Sorted: {IsSorted(new int[] {-4, -3, 0, 3, 6, 7, 8, 12})}");
                        break;
                    case("18"):
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Exercise not found.");
                        break;
                }


            }
        }

        //----------EXERCISE 1----------
        /// <summary>
        ///  Returns the sum of all numbers in the range [0,n] using recursion.
        /// </summary>
        /// <param name="n">Some number</param>
        /// <returns>The</returns>
        static int Exe1(int n)
        {
            if(n <= 0)
            {
                return 0;
            }

            else
            {
                return n + Exe1(n-1);
            }
        }

        //----------EXERCISE 2----------
        /// <summary>
        /// Returns the factorial of a given number using recursion.
        /// NOTE: This method works solely on non-negative numbers.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Factorial(int n)
        {
            Console.WriteLine($"Got: {n}");
            
            if(n<=1)
            {
                return 1;
            }

            else
            {
                return n * Factorial(n-1); //Each factorial 
            }
        }
        
        //----------EXERCISE 3----------
        /// <summary>
        /// returns the sum of all odd numbers between 1 and n.  <br/>
        /// NOTE: This function takes non-negative parameters only. 
        /// Negative integers will produce an exception.
        /// </summary>
        static int Exe3(int n)
        {
            if(n%2 == 0) //Makes sure the number is an odd number.
            {
                n = n-1;
            }

            if(n==1)
            {
                return 1;
            }

            else
            {
                return n += Exe3(n-2);
            }
        }

        //----------EXERCISE 4----------
        /// <summary>
        /// Takes in a positive integer and return the number of digits it has, <br/>
        /// NOTE: As stated, this method takes in a positive integer. If you insert a negative
        /// Integer, it will produce nonsense.
        /// </summary>
        static int CountDigits(int Num)
        {
            if(Num <= 9)
            {
                return 1;
            }

            else
            {
                return 1 + CountDigits(Num / 10);
            }
        }   

        //----------EXERCISE 5----------
        /// <summary>
        /// Returns The floor division of the input numbers.
        /// </summary>
        static int Divide(int Dividend, int Divisor)
        {
            if( (Dividend < 0 && Divisor > 0) || (Dividend > 0 && Divisor < 0) )
            {
                Console.WriteLine($"{Dividend}, {Divisor}");
                return -1 + Divide(Dividend + Divisor, Divisor);
            }

            if(Dividend - Divisor < 0)
            {
                return 0;
            }

            else
            {
                return 1 + Divide(Dividend - Divisor, Divisor);
            }
        }

        
        //----------EXERCISE 6----------
        /// <summary>
        /// Takes two input numbers and returns the first in the mod of the second.
        /// </summary>
        /// <param name="Number">The number to be counted</param>
        /// <param name="InModulos">In which mod the number will be counted.</param>
        /// <returns><code>Number % InModolus</code></returns>
        static int Modulo(int Number, int InModulos)
        {
            if( (Number < 0 && InModulos > 0) || (Number > 0 && InModulos < 0) )
            {
                return Modulo(Number + InModulos, InModulos);
            }

            if(Number < InModulos)
            {
                return Number;
            }

            else
            {
                return Modulo(Number - InModulos, InModulos);
            }
        }

        //----------EXERCISE 7----------
        /// <summary>
        /// <b> Exercise 7 </b> <br/>
        /// Returns wether or not an integer is divisable by another integer with no
        /// remainder.
        /// </summary>
        /// <param name="Number">The dividend</param>
        /// <param name="Base">The divisor</param>
        /// <returns>    
        /// <list type="bullet">
        /// <item>
        /// <description>True, if the Number divided by base returns an integer.</description>
        /// </item>
        /// <item>
        /// <description>False, if the number divide by the base returns a non-integer.</description>
        /// </item>
        /// </list>
        /// </returns>
        static bool Divisible(int Number, int Base)
        {
            if( ( Base < Number && (Base < 0 || Number < 0) ) || 
                ( Base > Number && (Base > 0 && Number > 0) ) )
            {
                return false;
            }

            else if(Number -  Base == 0)
            {
                return true;
            }

            else
            {
                return Divisible(Number - Base, Base);
            }
        }

        //----------EXERCISE 7----------
        /// <summary>
        /// Checks if a number is prime.
        /// </summary>
        /// <param name="Number">A number to check if prime</param>
        /// <param name="Divisor">A current divisor to check, for 
        /// the method's implementation.</param>
        /// <returns>True if the number is prime, False if it is not.</returns>
        private static bool IsPrime(int Number, int Divisor)
        {
            if(Number == 1) return false;

            if(Divisor == 1) return true;

            if(Number % Divisor == 0 || Number == 1) return false;

            else return IsPrime(Number, Divisor - 1);
        }

        public static bool IsPrime(int Number)
        {
            return IsPrime(Number, Number / 2);
        }


        //---------Exercise 8---------
        private static bool ParityConsistent(int Number, bool isEven)
        {
            int Digit = Number % 10; //Get current digit.

            if(Digit % 2 != (isEven ? 0 : 1)) return false; //If it does not match needed parity, retuen false.

            else if(Number / 10 == 0) return true; //If it does and this was the last digit to check, return true.

            //If the digit matches the expected parity but there are more digits to check,
            //continue to the next iteration.
            else return ParityConsistent(Number / 10, isEven);  
        }

        /// <summary>
        /// Checks if the digits of a number share the same parity.
        /// </summary>
        /// <param name="Number">The number to check the digits of.</param>
        /// <returns>True if the digits of the numebr share the same parity,
        /// false, if they don't </returns>
        public static bool ParityConsistent(int Number)
        {
            return ParityConsistent(Number / 10, (Number % 10) % 2 == 0);
        }


        //---------Exercise 9---------
        /// <summary>
        /// Returns the sum of all elements up to the given number
        /// in the series 1\*2 + 2^2 + 3\*2 + 4^2 ... n*2/n^2 
        /// </summary>
        /// <param name="Number">The position of the highest element to calculate</param>
        static int Exe10(int Number)
        {
            if(Number == 1)
            {
                return 2;
            }

            else
            {
                if(Number % 2 == 0) return (int)Math.Pow(Number, 2) + Exe10(Number - 1);
                else return Number * 2 + Exe10(Number - 1);
            }
        }

        //---------Exercise 11---------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="N">The position in the series</param>
        /// <returns>The Nth element of the series 1 - sqrt(3) + 5 - sqrt(7) ... +n/-sqrt(n)
        /// </returns>
        static double Exe11(int N)
        {
            if(N == 1) return 1;
            
            else
            {
                int SeriesInteger = 2*N - 1;

                if (N % 2 == 0) return -1 * Math.Sqrt(SeriesInteger) + Exe11(N-1);
                else return SeriesInteger + Exe11(N-1);
            }
        }

        //---------Exercise 12--------
        /// <summary>
        /// Calaculates the sum of all integer products of a specific intger that
        /// are less than an input number.
        /// </summary>
        /// <param name="Base">The base number, that the products will be of.</param>
        /// <param name="MaxPorduct">The maximum a product can be in the calculation.</param>
        /// <returns>The sum of all clean products of Base that are less than MaxProduct.</returns>
        static int Exe12(int Base, int MaxPorduct, int OriginalBase)
        {
            if(Base > MaxPorduct) return 0;
            else return Base + Exe12(Base + OriginalBase, MaxPorduct, OriginalBase);
        }
        
        /// <summary>
        /// Calaculates the sum of all integer products of a specific intger that
        /// are less than an input number.
        /// </summary>
        /// <param name="Base">The base number, that the products will be of.</param>
        /// <param name="MaxPorduct">The maximum a product can be in the calculation.</param>
        /// <returns>The sum of all clean products of Base that are less than MaxProduct.</returns>
        static int Exe12(int Base, int MaxPorduct)
        {
            return Exe12(Base, MaxPorduct, Base);
        }


        //----------Exercise 13----------
        //-----Part A-----
        /// <summary>
        /// Returns the nth number in the series where the first element is 0,
        /// the second is 1, and the rest are each the sum of the squares of the two previous
        /// one.
        /// </summary>
        /// <param name="N">The position in the series.</param>
        /// <returns>The Nth positioned element in the series.</returns>
        static int Exe13A(int N)
        {
            if(N == 1) return 0;
            if(N == 2) return 1;
            return (int)(Math.Pow(Exe13A(N-1), 2) + Math.Pow(Exe13A(N-2), 2));
        }

        //-----Part B-----
        /// <summary>
        /// Returns the sum, up to th input position, of the series where the first element is 0,
        /// the second is 1, and the rest are each the sum of the squares of the two previous
        /// one.
        /// </summary>
        /// <param name="N">The position in the series.</param>
        /// <returns>The sum up Nth positioned element in the series.</returns>
        static int Exe13B(int N)
        {
            if(N == 1) return 0;
            else return Exe13A(N) + Exe13B(N-1);
        }


        //---------Exercise 14---------
        static int SumUpTo(int[] Array, int Index)
        {
            if (Index == 0)
            {
                return Array[0];
            }

            else
            {
                return Array[Index] + SumUpTo(Array, Index - 1);
            }
        }

        //---------Exercise 15--------
        /// <summary>
        /// Counts how many positive integers there are in an array up until a specified index.
        /// </summary>
        /// <param name="Array">The array to be checked.</param>
        /// <param name="Index">The inndex to check up to. Note that as this is an index,
        /// it must be nonnegtive and cannot be more than the length of the array.</param>
        /// <returns>The amount of positive numbers in the array.</returns>
        static int CountPositives(int[] Array, int Index)
        {
            int CurrentNumber = Array[Index];
            
            if(Index == 0)
            {
                if(CurrentNumber > 0) return 1;
                else return 0;
            }

            else
            {
                if(CurrentNumber > 0) return 1 + CountPositives(Array, Index - 1);
                else return 0 + CountPositives(Array, Index - 1);
            }
        }

        //---------Exercise 16--------
        private static int IndexOf(int[] Array, int Element, int Index)
        {
            if(Index == -1) return -1;
            if(Array[Index] == Element) return Index;
            else return IndexOf(Array, Element, Index - 1);
        }


        /// <summary>
        /// Checks for the position of an element ina n array.
        /// </summary>
        /// <param name="Array">The array to search.</param>
        /// <param name="Element">The element to search for.</param>
        /// <returns>The position of Elment in Array, or -1 if Element is not there.</returns>
        public static int IndexOf(int[] Array, int Element)
        {
            return IndexOf(Array, Element, Array.Length - 1);
        } 

        //---------Exercise 17--------
        private static bool IsSorted(int[] Array, int Index)
        {
            if(Index == -1) return true;
            if(Array[Index] < Array[Index + 1]) return false;
            else return IsSorted(Array, Index - 1);
        }

        /// <summary>
        /// Checks wether an integer array is sorted (lowest to highest).
        /// </summary>
        /// <param name="Array">The array to check.</param>
        /// <returns>True if the array is sorted, False if not.</returns>
        public static bool IsSorted(int[] Array)
        {
            return IsSorted(Array, Array.Length - 2);
        }

        


    }
}