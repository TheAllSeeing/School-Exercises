﻿using System;
using System.Collections.Generic;

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

        static int[] RequestArr()
        {
            string Ans = String.Empty;
            List<int> ElementList = new List<int>();
            Console.WriteLine("Please insert the first element");
            ElementList.Add(int.Parse(Console.ReadLine()));

            while (Ans != "F")
            {
                Console.WriteLine("Please insert the next element, or type F to finish.");
                Ans = Console.ReadLine();
                if(Ans != "F")
                {
                    ElementList.Add(int.Parse(Ans));
                }
            }

            return ElementList.ToArray();
        }

        static string Readable(int Num)
        {
            string UnReadable = Num.ToString();
            string Readable = String.Empty; 
            for (int i = Readable.Length - 1; i >= 0 ; i++)
            {
                Readable += UnReadable[i].ToString();
                if (i % 3 == 0 && i != 0) Readable += ",";
            }
            return Readable;
        }

        static void Main(string[] args)
        {
            int Result;
            int Number;
            string String;
            int[,] Array2D = {{0, -6, -3, 3, 7, -8, 12,  4},
                              {0,  6,  3, 3, 5,  8, 12, -4},
                              {9,  6,  3, 3, 7,  8, 12,  4},
                              {4, -3,  0, 2, 9,  7,  4, 12}};
            int[][] JaggedArray = {new int[] {0, -6, -3, 3, 7, -8, 12,  4},
                                   new int[] {0,  6,  65, 3, 5,  8, 12, -4},
                                   new int[] {9,  6,  3, 3, 86,  8, 12,  4},
                                   new int[] {4, -3,  0, 42, 9,  7,  4, 12}};

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
                        Console.WriteLine($"Unsorted: {IsSorted(new int[] {0, 6, 3, -3, 7, 8, 12, -4})}");
                        Console.WriteLine($"Sorted: {IsSorted(new int[] {-4, -3, 0, 3, 6, 7, 8, 12})}");
                        break;
                    case("18"):
                        Console.WriteLine("This Program checks if an array contains primes. "
                        + "We will test it with two arrays: [9, 6, 3, 3, 7, 8, 12, 4], "
                        + "and it with its primes removed ([4, 9, 6, 8, 12]).");
                        Console.WriteLine($"Contains:{HasNoPrimes(new int[] {9, 6, 3, 3, 7, 8, 12, 4})}");
                        Console.WriteLine($"Does not contain: {HasNoPrimes(new int[] {4, 9, 6, 8, 12})}");
                        break;
                    case("19"):
                        Console.WriteLine("This program checks how many lines in a two-deimensional "
                        + "array contain an input value. For this demonstration, we will use the array");
                        Console.WriteLine(
                            "{{0, -6, -3, 3, 7, -8, 12,  4},\n" +
                            " {0,  6,  3, 3, 5,  8, 12, -4},\n" +
                            " {9,  6,  3, 3, 7,  8, 12,  4},\n" +
                            " {4, -3,  0, 2, 9,  7,  4, 12}}"
                        );
                        Console.WriteLine("Please insert the value to check for.");
                        int Request = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{Request} appears in the array in"
                        + $"{CountLines(Array2D, Request)} lines.");
                        break;
                    case("20"):
                        Console.WriteLine("this program checks if sections of an array are "
                        + "a palindrom. This demonnstration uses the array {5, 2, 2, 5, 2, 7, 8, 0}\n"
                        + "Now, please insert a 0-based starting index");
                        int[] Arr = {5, 2, 2, 5, 2, 7, 8, 0};
                        int Start = int.Parse(Console.ReadLine());
                        Console.WriteLine("And now, a 0-based end index.");
                        int End = int.Parse(Console.ReadLine());
                        Console.WriteLine("The resulting sectio is "
                        + (IsPalindrom<int>(Arr, Start, End)? "a palindrom" : "not a palindrom."));                    
                        break;
                    case("21"):
                        Console.WriteLine("Please insert a string, and we will check how many"
                        + "lower case letters it contains");
                        String = Console.ReadLine();
                        Console.WriteLine($"{String} contains {CountLowerLetters(String)} lower letters.");
                        break;
                    case("22"):
                        Console.WriteLine("Please insert a string, and we will add asterisks to"
                        + "it after every three characters.");
                        Console.WriteLine($"Result: {AddAsterisks(Console.ReadLine())}");
                        break;
                    case("23"):
                        Console.WriteLine("Please insert a string, and we will reverse it.");
                        Console.WriteLine($"Result: {ReverseString(Console.ReadLine())}");
                        break;
                    case("24"):
                        Console.WriteLine("This program receives two letters and prints out "
                        + "all letters between them.\nNow, please insert the start letter.");
                        char StartChar = char.Parse(Console.ReadLine());
                        Console.WriteLine("And now, please insert the end character.");
                        char EndChar = char.Parse(Console.ReadLine());
                        Console.WriteLine("\nResult...\n");
                        PrintLetterRange(StartChar, EndChar);
                        Console.WriteLine(".\n");
                        break;
                    case("25"):
                        Console.WriteLine("Please inser an integer, and we will print out "
                        + "all of its divisors.\n");
                        Number = int.Parse(Console.ReadLine());
                        Console.Write("Divisors: ");
                        PrintDivisors(Number);
                        break;
                    case("26"):
                        Console.WriteLine("Please insert an integer, and we will print out "
                        + "all of its even digits.");
                        Number = int.Parse(Console.ReadLine());
                        Console.Write("Even digits: ");
                        PrintEvenDigits(Number);
                        Console.WriteLine();
                        break;
                    case("27"):
                        Console.WriteLine("MULTIPLICATION BOARD:");
                        MultiplictionBoard();
                        Console.WriteLine();
                        break;
                    case("28"):
                        Console.WriteLine("This program prints elements of an arithmic progression "
                        + "by input values.\nFirst, we need to know the first element of the progression.");
                        int a1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second, we need the difference between adjacent elements"
                        + "of the progression.");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Finally, we need to know how many elements you'd like me to print.");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: ");
                        PrintSeries(a1, d, n);
                        break;
                    case("29"):
                        Console.WriteLine("This program prints put the elements of the"
                        + "series 1, 2, 4, 7, 11, 16, 22...\nPlease, insert the number of elements"
                        + "from that series you;d like us to print.");
                        Exe29(int.Parse(Console.ReadLine()));
                        break;
                    case("30"):
                        Console.WriteLine("This program prints out the elemets of the series which "
                        + "starts at 4 and thenn subtructs 1, adds 2 for each pair of elements.\n"
                        + "Now, please tell us how many elements do you want us to print?\n");
                        Exe30(int.Parse(Console.ReadLine()));
                        break;
                    case("31"):
                        Console.WriteLine("This program prints every second index of an array.\n"
                        + "Now, we need an array.");
                        Arr = RequestArr();
                        Console.WriteLine("Resulting array: " + PrntArr(Arr));
                        Console.WriteLine("Even indexed: ");
                        PrintEven(Arr);
                        Console.WriteLine();
                        break;
                    case("32"):
                        Console.WriteLine("This program prints every elment of an array that is "
                        + "smaller than the one after it.\n"
                        + "Now, we need an array.");
                        Arr = RequestArr();
                        Console.WriteLine("Resulting array: " + PrntArr(Arr));
                        Console.WriteLine("Greater than their next: ");
                        Exe32(Arr);
                        Console.WriteLine();
                        break;
                    case("33"):
                        Console.WriteLine("Printing Array...\n");
                        Print2DArr(Array2D);
                        break;
                    case("34"):
                        Console.WriteLine("This Program checks the maximum of each line of a two dimensional "
                        + "array. We will use the following array: ");
                        Print2DArr(Array2D);
                        Console.WriteLine();
                        PrintMaximums(JaggedArray);
                        break;
                    case("35"):
                        Console.WriteLine("This program prits out a subsection of a two-dimesional "
                        + "array, determined by an input left corner.\n We will use the following array");
                        Print2DArr(Array2D);
                        Console.WriteLine("Now, please inser the line"
                        + "of the left corner.");
                        int CornerLine = int.Parse(Console.ReadLine());
                        Console.WriteLine("And now, its column.");
                        int CornerColumn = int.Parse(Console.ReadLine());
                        PrintSubArr(Array2D, CornerLine, CornerColumn);
                        break;
                    case("42"):
                        Console.WriteLine("Please innsert a number and we will print its check digit.");
                        Console.WriteLine($"Result: {CheckDigit(int.Parse(Console.ReadLine()))}");
                        break;
                    case("44"):
                        Console.WriteLine("This program calculates the amount of "
                        + "possible routes from the left corner of a 10x10 board to its bottom-right."
                        + $"\nOur result? {/*Readable(*/CalculateRoutes()/*)*/}");
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

        //----------EXERCISE 8----------
        /// <summary>
        /// Checks if a number is prime.
        /// </summary>
        /// <param name="Number">A number to check if prime</param>
        /// <param name="Divisor">A current divisor to check, for 
        /// the method's implementation.</param>
        /// <returns>True if the number is prime, False if it is not.</returns>
        private static bool IsPrime(int Number, int Divisor)
        {

            if(Divisor == 1) return true;

            if(Number % Divisor == 0 || Number == 1) return false;

            else return IsPrime(Number, Divisor - 1);
        }

        public static bool IsPrime(int Number)
        {
            return IsPrime(Number, Number / 2);
        }


        //---------Exercise 9---------
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


        //---------Exercise 10---------
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
            if(Array[Index] > Array[Index + 1]) return false;
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

        //---------Exercise 18--------
        private static bool HasNoPrimes(int[] Array, int Index)
        {
            if(Index == -1) return true;
            if(IsPrime(Array[Index])) return false;
            else return HasNoPrimes(Array, Index - 1);
        }

        /// <summary>
        /// Checks wether an integer array contains primes..
        /// </summary>
        /// <param name="Array">The array to check.</param>
        /// <returns>False if the array contains any prime numbers, True if it does not.</returns>
        public static bool HasNoPrimes(int[] Array)
        {
            return HasNoPrimes(Array, Array.Length - 1);
        }

        //---------Exercise 19--------
        private static int CountLines(int[,] Array, int Value, int LastLine)
        {

            for (int i = 0; i < Array.GetLength(0); i++) //Iterate through a lines of the array.
            {
                if(Array[LastLine,i] == Value) //If you find the value
                {
                    //If its not the last line to check, add 1 and check the next line.
                    if(LastLine==0) return 1 + CountLines(Array, Value, LastLine - 1);
                    //If it it the last line, return 1 since there are no more lines to check.
                    else return 1; 
                } 
            }

            if(LastLine == 0) return 0 + CountLines(Array, Value, LastLine);
            else return 0;
        }

        /// <summary>
        /// Counts the amount of lines in a two-dimensional array that contain an input value.
        /// </summary>
        /// <param name="Array">The two-dimensional array to check the lines of.</param>
        /// <param name="Value">The value to look for</param>
        /// <returns>The amount of lines in Array that contain Value.</returns>
        public static int CountLines(int[,] Array, int Value)
        {
            return CountLines(Array, Value, Array.GetLength(0)  - 1);
        }        

        //---------Exercise 20--------
        /// <summary>
        /// Checks if a section of an array is a "palidrom".
        /// A section is palindrom if it is identical read from right and read from left. 
        /// </summary>
        /// <param name="Arr">The array to check the section of.</param>
        /// <param name="Start">The start index of the section of the array.</param>
        /// <param name="End">The end index of the section of the array.</param>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <returns>True if the section is a palindrom, false if it's not.</returns>
        static bool IsPalindrom<T>(T[] Arr, int Start, int End)
        {
            int Mid = (int)Math.Ceiling((Start + End) / 2.0 );
            if(Start == End|| End < Mid) return true;
            if(Arr[Start].Equals(Arr[End])) return IsPalindrom<T>(Arr, Start + 1, End - 1);
            else return false;
        }

        //---------Exercise 21--------
        private static int CountLowerLetters(string String, int Character)
        {
            if(Character == String.Length - 1)
            {
                if(char.IsLower(String[Character])) return 1;
                else return 0;
            }

            if(char.IsLower(String[Character])) return 1 + CountLowerLetters(String, Character + 1);
            else return 0 + CountLowerLetters(String, Character + 1);
        }

        /// <summary>
        /// Counts how many lower-case letters there are ina string. 
        /// </summary>
        /// <param name="String">The string to check.</param>
        /// <returns>How many lower-case characters there are in a string.</returns>
        public static int CountLowerLetters(string String)
        {
            return CountLowerLetters(String, 0);
        }

        //---------Exercise 22--------
        /// <summary>
        /// Adds an asterisk to a string every three letters.
        /// </summary>
        /// <param name="String">The string to add asterisks to.</param>
        /// <returns>The input string with an added asterisk after every three letters.</returns>
        static string AddAsterisks(string String)
        {
            if(String.Length < 3) return String;
            string NewString = String.Substring(0,3) + "*";
            String = String.Remove(0,3);
            return NewString + AddAsterisks(String);
        }        


        //---------Exercise 23--------
        private static string ReverseString(string String, int Index)
        {
            if(Index == 0) return String[0].ToString();
            else return String[Index].ToString() + ReverseString(String, Index - 1);
        }

        public static string ReverseString(string String)
        {
            return ReverseString(String, String.Length - 1);
        }

        //---------Exercise 24--------
        static void PrintLetterRange(char Start, char End)
        {
            Start = char.ToLower(Start);
            End = char.ToLower(End);

            Console.WriteLine(Start);
            if(Start != End)
            {
                int NextLetter = (int)Start + 1;
                PrintLetterRange((char)NextLetter, End);
            }
        }

        //---------Exercise 25--------
        private static void PrintDivisors(int N, int Divisor)
        {
            if(N % Divisor == 0) 
            {
                Console.Write(Divisor);

                if(Divisor != 1) Console.Write(", ");
            }

            if(Divisor == 1)
            {
                Console.Write(".\n");
                return;
            }

            else 
            {
                PrintDivisors(N, Divisor - 1);
            }
        }

        /// <summary>
        /// Prints all divisors of an input number.
        /// </summary>
        /// <param name="N">The number to print the divisors of</param>
        public static void PrintDivisors(int N)
        {
            PrintDivisors(N, N);
        }

        //---------Exercise 26--------
        /// <summary>
        /// Prints all even digits of an input integer.
        /// </summary>
        /// <param name="N">The number to print even digits of.</param>
        static void PrintEvenDigits(int N)
        {
            if(N % 10 % 2 == 0) Console.Write(N % 10 + ","); //If current digit is even, print it.
            if(N < 10) return; //If it's the last digit, return.
            PrintEvenDigits(N / 10);
        }

        //---------Exercise 27--------
        static void MultipicationBoard(int Column, int Line)
        {
            if(Column == 1) Console.WriteLine("\n");
            int Num = Column * Line;
            Console.Write(Num);
            if(Num < 10) Console.Write(" ");
            Console.Write(" ");
            if(Num == 100) return;
            if(Column < 10) MultipicationBoard(Column + 1, Line);
            else MultipicationBoard(1, Line + 1);
        }

        /// <summary>
        /// Prints out a 1-10 multiplicationn board.
        /// </summary>
        static void MultiplictionBoard()
        {
            MultipicationBoard(1, 1);
        }

        //---------Exercise 28--------
        /// <summary>
        /// Gets the first element of an arithmic progression and its difference,
        /// and prints out the elements of the series until input position.
        /// </summary>
        /// <param name="a1">The first element of the series.</param>
        /// <param name="d">The differennce between each two elements.</param>
        /// <param name="n">The amount of elements to print.</param>
        static void PrintSeries(int a1, int d, int n)
        {
            Console.Write(a1 + ", ");
            if(n == 0) return;
            PrintSeries(a1 + d, d, n-1);
        }

        //---------Exercise 29--------
        /// <summary>
        /// Prints out elments of the series 1, 2, 4, 7, 16... (where the difference
        /// grows by one after each elment) until a given input, and returns the series'
        /// value at that point.
        /// </summary>
        /// <param name="N">The poistion of the lement to return and print until.</param>
        /// <param name="Iteration"></param>
        /// <param name="LastValue"></param>
        static void Exe29(int N, int Iteration, int LastValue)
        {
            int NewValue = LastValue + Iteration - 1;
            Console.Write($"{NewValue}, "); 

            if (Iteration != N)
            {
                Exe29(N, Iteration + 1, NewValue);
            }
        }

        public static void Exe29(int N)
        {
            Exe29(N, 1, 1);
        }


        //---------Exercise 30--------
        static void Exe30(int N, int Iteration)
        {
            if (Iteration % 2 == 1)
            {
                Console.Write($"{4 + Iteration/2}, ");
            }

            else
            {
                Console.Write($"{2 + Iteration/2}, ");
            }

            if(N != Iteration)
            {
                Exe30(N, Iteration + 1);
            }

            else Console.WriteLine();
        }

        /// <summary>
        /// Prints out elements of the series which starts at 4 and then subtructs one, add two
        /// for every pair of elements.
        /// </summary>
        /// <param name="N">The amount of elements to print.</param>
        public static void Exe30(int N)
        {
            Exe30(N, 1);
        }


        //---------Exercise 31-------
        private static void PrintEven<T>(T[] Array, int Index)
        {
            if(Index >= Array.Length) return;

            Console.Write($"{Array[Index]}, ");
            PrintEven<T>(Array, Index + 2);
        }

        /// <summary>
        /// Prints every second element of an array, starting at element 0.
        /// </summary>
        /// <param name="Array">The array to print the elements of.</param>
        /// <typeparam name="T">The array's type.</typeparam>
        public static void PrintEven<T>(T[] Array)
        {
            PrintEven<T>(Array, 0);
        }

        //---------Exercise 32-------
        private static void Exe32(int[] Arr, int Index)
        {
            if (Arr[Index] < Arr[Index + 1])
            { 
                Console.Write($"{Arr[Index]}, ");
            }

            if (Index < Arr.Length - 2)
            {
                Exe32(Arr, Index + 1);
            }

        }

        /// <summary>
        /// Prints out all elements of an input array that are smaller than their following
        /// value.
        /// </summary>
        /// <param name="Arr">The array to check.</param>
        public static void Exe32(int[] Arr)
        {
            Exe32(Arr, 0);
        }

        
        //---------Exercise 33--------
        static void Print2DArr(int[,] Arr, int Column, int Line)
        {
            int Element = Arr[Line, Column];
         
            if(Column == 0 && Line == 0)
            {
                Console.Write("{{" + Element + ",");
            }
             
            else if (Column == 0) 
            {
                Console.Write("\n {" + Element + ", ");                
            }

            else if(Column == Arr.GetLength(1) - 1)
            {
                Console.Write(Element + "}");
            }

            else 
            {
                Console.Write($"{Element}, ");
            }

            if (Math.Abs(Element) < 10) Console.Write(" ");
            if (Element > 0) Console.Write(" ");
            //If it's not the end of the array
            if(!(Column == Arr.GetLength(1) - 1 && Line == Arr.GetLength(0) - 1))
            {
                if (Column < Arr.GetLength(1) - 1)
                {
                    Print2DArr(Arr, Column + 1, Line);
                }
                
                else
                {
                    Print2DArr(Arr, 0, Line + 1);
                }
            }

            else Console.WriteLine(); ;
        }

        /// <summary>
        /// Print out a 2D array.
        /// </summary>
        /// <param name="Arr">The array to print.</param>
        static void Print2DArr(int[,] Arr)
        {
            Print2DArr(Arr, 0, 0);
        }


        //---------Solved Exercise 5--------
        public static int GetMax(int[] Arr, int Left, int Right)
        {
            if (Left == Right)
            {
                return Arr[Left];
            }

            if(Arr[Left] > Arr[Right])
            {
                return GetMax(Arr, Left, Right - 1); //Compare the larger element against the next element.
            }

            else
            {
                return GetMax(Arr, Left + 1, Right);
            }
        }

        static int GetMax(int[] Arr)
        {
            return GetMax(Arr, 0, Arr.Length - 1);
        }

        //---------Exercise 34--------
        /// <summary>
        /// Prints the maximum value from each line of a multidimensional array. 
        /// </summary>
        /// <param name="Arr">The array to check</param>
        static void PrintMaximums(int[][] Arr, int Line=0)
        {
            Console.WriteLine();
            Console.WriteLine(PrntArr(Arr[Line]) + " : " + GetMax(Arr[Line]));
            
            if (Line != Arr.Length - 1)
            {
                PrintMaximums(Arr, Line + 1);
            }
        }

        //---------Exercise 35--------
        static void PrintSubArr(int[,] Arr, int i, int j, int OriginalJ)
        {
            int Element = Arr[i, j];

            Console.Write(Element + " ");

            if (Math.Abs(Element) < 10) Console.Write(" ");
            if (Element > 0) Console.Write(" ");

            if (j == Arr.GetLength(1) - 1) //If it's the last in line, go the next line.
            {
                Console.WriteLine();
            }

            //If it's not the end of the array 
            if (!(j == Arr.GetLength(1) - 1 && i == Arr.GetLength(0) - 1))
            {
                if (j < Arr.GetLength(1) - 1) //If it's not the last column
                {
                    PrintSubArr(Arr, i, j + 1, OriginalJ); //Move to the next element in line.
                }
                
                else //If it is
                {
                    Console.WriteLine(); //Move typer to next line.
                    PrintSubArr(Arr, i + 1, OriginalJ, OriginalJ); //Move to the start of next line
                }
            }
        }

        /// <summary>
        /// Prints a sub-array of a two-dimensional array, with the left corner [i,j].
        /// </summary>
        /// <param name="Arr">The array to print the sub-array of.</param>
        /// <param name="i">The left corner's line</param>
        /// <param name="j">The left corner's line</param>
        static void PrintSubArr(int[,] Arr, int i, int j)
        {
            PrintSubArr(Arr, i, j, j);
        }

        //---------Exercise 42--------
        static int DigitSum(int Number)
        {
            if(Number == 0) return 0;

            else return DigitSum(Number / 10) + Number % 10;
        }

        /// <summary>
        /// Calculates a number's check digit - the result of iterative digit summation
        /// until the result is single-digit. 
        /// </summary>
        /// <param name="Number">The number to calculate the check digit of.</param>
        /// <returns>The number's check digit.</returns>
        static int CheckDigit(int Number)
        {
            int Sum = DigitSum(Number);
            if(Sum < 10) return Sum;
            else return CheckDigit(Sum);
        }

        

        //---------Exercise 44--------
        static int CalculateRoutes(int LastRow, int LastColumn, bool Down, bool Right)
        {
            int NewRow = LastRow + (Down ? 1 : 0);
            int NewColumn = LastColumn + (Right ? 1 : 0);

            if (NewRow == 9 && NewColumn == 9)
            {
                return 1;
            }

            else
            {
                return
                    (NewRow != 9 && NewColumn != 9 ? //If there's space for diagonal
                        CalculateRoutes(NewRow, NewColumn, true, true) : 0) //Possibilities Diagonal 
                    + (NewColumn != 9 ? //If ther'es space for moving right.
                        CalculateRoutes(NewRow, NewColumn, false, true) : 0) //Possibilites Right
                    + (NewRow != 9 ? //If ther'es space for moving down
                        CalculateRoutes(NewRow, NewColumn, true, false) : 0); //Possibilites Down
            }
        }

        /// <summary>
        /// Calculates possible routes from the left corner of a 10x10 board to its bottom-right.
        /// </summary>
        /// <returns>The amount of possible routes from the left corner of a 10x10 board to its bottom-right.</returns>
        static int CalculateRoutes()
        {
            return
                CalculateRoutes(0, 0, true, true)
                + CalculateRoutes(0, 0, true, false) 
                + CalculateRoutes(0, 0, false, true);
        }

        //---------Exercise 45--------
        static int NeighboreSequence(char[,] Neighborhood, int Line, int Column)
        {
            int Res = 0;
            int[] Directions = {0, 1, -1};
            foreach (int ColumnDir in Directions)
            {
                foreach (int RowDir in Directions)
                {
                    if(Neighborhood[Line + RowDir, Column + ColumnDir] == 'x')
                    {
                        Res += NeighboreSequence(Neighborhood, Line + RowDir, Column + ColumnDir);
                        return Res;
                    }

                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}