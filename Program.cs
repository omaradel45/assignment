//1 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3)
//and determines whether these points lie on a single straight line.

//using System;

//Console.Write("Enter x1, y1: ");
//var p1 = Console.ReadLine().Split(',');
//double x1 = double.Parse(p1[0]), y1 = double.Parse(p1[1]);

//Console.Write("Enter x2, y2: ");
//var p2 = Console.ReadLine().Split(',');
//double x2 = double.Parse(p2[0]), y2 = double.Parse(p2[1]);

//Console.Write("Enter x3, y3: ");
//var p3 = Console.ReadLine().Split(',');
//double x3 = double.Parse(p3[0]), y3 = double.Parse(p3[1]);

//double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);


//Console.WriteLine(area == 0 ? "Points are collinear." : "Points are not collinear.");

//-------------------------------------------------------------------------------------------------------------------

//2 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
//- If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
//- If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
//- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
//- If the worker takes more than 5 hours, they are required to leave the company. 
//To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.


//using System;

//Console.Write("\nEnter time taken by worker in hours: ");
//double time = double.Parse(Console.ReadLine());
//if (time >= 2 && time < 3)
//    Console.WriteLine("Highly efficient");
//else if (time >= 3 && time < 4)
//    Console.WriteLine("Increase speed");
//else if (time >= 4 && time < 5)
//    Console.WriteLine("Training required");
//else if (time >= 5)
//    Console.WriteLine("Leave the company");

//-------------------------------------------------------------------------------------------------------------------

//3 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

//using System;

//Console.Write("\nEnter the size of identity matrix: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(i == j ? "1 " : "0 ");
//    }
//    Console.WriteLine();
//}

//-------------------------------------------------------------------------------------------------------------------

//20 - Write a program in C# Sharp to find the sum of all elements of the array.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int size = 0;
//        int[] arr = null;

//        // Question 20: Sum of Array Elements
//        Console.Write("\nEnter array size: ");
//        size = int.Parse(Console.ReadLine());
//        arr = new int[size];
//        Console.WriteLine("Enter array elements:");
//        for (int i = 0; i < size; i++)
//            arr[i] = int.Parse(Console.ReadLine());

//        int sum = 0;
//        foreach (int num in arr)
//            sum += num;

//        Console.WriteLine("Sum of array elements: " + sum);

//-------------------------------------------------------------------------------------------------------------------

//21 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


//using System;

// class Program
//{
//    static void Main()
//    {
//        int[] array1 = { 1, 3, 5, 7, 9 };
//        int[] array2 = { 2, 4, 6, 8, 10 };
//        int[] mergedArray = new int[array1.Length + array2.Length];

//        int i = 0, j = 0, k = 0;

//        while (i < array1.Length && j < array2.Length)
//        {
//            if (array1[i] < array2[j])
//                mergedArray[k++] = array1[i++];
//            else
//                mergedArray[k++] = array2[j++];
//        }

//        while (i < array1.Length)
//            mergedArray[k++] = array1[i++];

//        while (j < array2.Length)
//            mergedArray[k++] = array2[j++];

//        Console.WriteLine("Merged Array: ");
//        foreach (var item in mergedArray)
//            Console.Write(item + " ");
//    }
//}


//-------------------------------------------------------------------------------------------------------------------

//22 - Write a program in C# Sharp to count the frequency of each element of an array.

//using System;
//using System.Collections.Generic;

// class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
//        Dictionary<int, int> frequency = new Dictionary<int, int>();

//        foreach (int num in array)
//        {
//            if (frequency.ContainsKey(num))
//                frequency[num]++;
//            else
//                frequency[num] = 1;
//        }

//        foreach (var pair in frequency)
//        {
//            Console.WriteLine($"Element {pair.Key} appears {pair.Value} times.");
//        }
//    }
//}

//-------------------------------------------------------------------------------------------------------------------

//23 - Write a program in C# Sharp to find maximum and minimum element in an array

//using System;

// class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        int max = array[0];
//        int min = array[0];

//        foreach (int num in array)
//        {
//            if (num > max)
//                max = num;
//            if (num < min)
//                min = num;
//        }

//        Console.WriteLine($"Maximum element: {max}");
//        Console.WriteLine($"Minimum element: {min}");
//    }
//}


//-------------------------------------------------------------------------------------------------------------------

//24 - Write a program in C# Sharp to find the second largest element in an array.


//using System;

// class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6 };
//        int firstMax = int.MinValue;
//        int secondMax = int.MinValue;

//        foreach (int num in array)
//        {
//            if (num > firstMax)
//            {
//                secondMax = firstMax;
//                firstMax = num;
//            }
//            else if (num > secondMax && num < firstMax)
//            {
//                secondMax = num;
//            }
//        }

//        if (secondMax != int.MinValue)
//            Console.WriteLine($"Second largest element: {secondMax}");
//        else
//            Console.WriteLine("No second largest element found.");
//    }
//}


//-------------------------------------------------------------------------------------------------------------------

// Question 25

//using System;
//using System.Collections.Generic;

// class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter the number of elements in the array:");
//        int n = int.Parse(Console.ReadLine());

//        int[] array = new int[n];
//        Console.WriteLine("Enter the array elements:");
//        for (int i = 0; i < n; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
//        int maxDistance = -1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (firstOccurrence.ContainsKey(array[i]))
//            {
//                int distance = i - firstOccurrence[array[i]];
//                if (distance > maxDistance)
//                    maxDistance = distance;
//            }
//            else
//            {
//                firstOccurrence[array[i]] = i;
//            }
//        }

//        if (maxDistance != -1)
//            Console.WriteLine($"The longest distance between two equal cells is {maxDistance}.");
//        else
//            Console.WriteLine("No equal cells found.");
//    }
//}

//-------------------------------------------------------------------------------------------------------------------


// Question 26

//using System.Linq;
//using System;

//Console.Write("\nEnter a sentence: ");
//string sentence = Console.ReadLine();
//string reversed = string.Join(" ", sentence.Split(' ').Reverse());
//Console.WriteLine("Reversed sentence: " + reversed);

//-------------------------------------------------------------------------------------------------------------------

//27 - Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. 
//    Now copy all the elements of first array on second array and print second array.

//using System;

//Console.Write("\nEnter dimensions for 2D array (rows, cols): ");
//var dimensions = Console.ReadLine().Split(',');
//int rows = int.Parse(dimensions[0]);
//int cols = int.Parse(dimensions[1]);
//int[,] array2D = new int[rows, cols];
//int[,] copiedArray = new int[rows, cols];

//Console.WriteLine("Enter elements for the array:");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        array2D[i, j] = int.Parse(Console.ReadLine());
//        copiedArray[i, j] = array2D[i, j];
//    }
//}

//Console.WriteLine("Copied Array:");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//        Console.Write(copiedArray[i, j] + " ");
//    Console.WriteLine();
//}

//-------------------------------------------------------------------------------------------------------------------

//28 - Write a Program to Print One Dimensional Array in Reverse Order

//using System;

//Console.WriteLine("\nArray in reverse order:");
//Array.Reverse(arr);
//Console.WriteLine(string.Join(", ", arr));

//-------------------------------------------------------------------------------------------------------------------

//fuctions

//1 - Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

//using System;

//void ValueExample(int x)
//{
//    x += 10; // Changes local copy only
//}

//void ReferenceExample(ref int x)
//{
//    x += 10; // Changes the original variable
//}

//int number = 5;
//Console.WriteLine("Original: " + number);
//ValueExample(number);
//Console.WriteLine("After ValueExample: " + number);
//ReferenceExample(ref number);
//Console.WriteLine("After ReferenceExample: " + number);

//-------------------------------------------------------------------------------------------------------------------


//2 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

//using System;

//void RefTypeByValue(string s)
//{
//    s += " World"; // Changes local copy of the reference
//}

//void RefTypeByReference(ref string s)
//{
//    s += " World"; // Changes the original reference
//}

//string text = "Hello";
//Console.WriteLine("Original: " + text);
//RefTypeByValue(text);
//Console.WriteLine("After RefTypeByValue: " + text);
//RefTypeByReference(ref text);
//Console.WriteLine("After RefTypeByReference: " + text);

//-------------------------------------------------------------------------------------------------------------------

//3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


//using System;

//class Program
//{
//    static (int summation, int subtraction) SumAndSubtract(int num1, int num2, int num3, int num4)
//    {
//        int summation = num1 + num2 + num3 + num4;
//        int subtraction = num1 - num2 - num3 - num4;

//        return (summation, subtraction);
//    }

//    static void Main()
//    {
//        Console.WriteLine("Enter the first number:");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the second number:");
//        int num2 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the third number:");
//        int num3 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the fourth number:");
//        int num4 = int.Parse(Console.ReadLine());

//        var result = SumAndSubtract(num1, num2, num3, num4);

//        Console.WriteLine($"The summation of the numbers is: {result.summation}");
//        Console.WriteLine($"The subtraction of the numbers is: {result.subtraction}");
//    }
//}


//-------------------------------------------------------------------------------------------------------------------

//question 4

//using System;

//Console.WriteLine("\n4. Sum of the Digits of a Number:");
//int SumOfDigits(int num)
//{
//    int sum = 0;
//    while (num > 0)
//    {
//        sum += num % 10;
//        num /= 10;
//    }
//    return sum;
//}

//Console.Write("Enter a number: ");
//int digitNum = int.Parse(Console.ReadLine());
//Console.WriteLine($"The sum of the digits of {digitNum} is: {SumOfDigits(digitNum)}");

//-------------------------------------------------------------------------------------------------------------------

// 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

//using System;

//Console.WriteLine("\n5. Check if a Number is Prime:");
//bool IsPrime(int number)
//{
//    if (number <= 1) return false;
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        if (number % i == 0) return false;
//    }
//    return true;
//}

//Console.Write("Enter a number to check for primality: ");
//int primeCheck = int.Parse(Console.ReadLine());
//Console.WriteLine(IsPrime(primeCheck) ? "The number is prime." : "The number is not prime.");

//-------------------------------------------------------------------------------------------------------------------

//6 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

//using System;

//Console.WriteLine("\n6. Min and Max of an Array:");
//void MinMaxArray(int[] array, out int min, out int max)
//{
//    min = array[0];
//    max = array[0];
//    foreach (int num in array)
//    {
//        if (num > max) max = num;
//        if (num < min) min = num;
//    }
//}

//Console.Write("Enter array size: ");
//int size = int.Parse(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("Enter array elements:");
//for (int i = 0; i < size; i++)
//    arr[i] = int.Parse(Console.ReadLine());

//MinMaxArray(arr, out int min, out int max);
//Console.WriteLine($"Minimum: {min}, Maximum: {max}");

//-------------------------------------------------------------------------------------------------------------------

//7 - Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter


//using System;

//Console.WriteLine("\n7. Factorial of a Number:");
//int Factorial(int num)
//{
//    int result = 1;
//    for (int i = 1; i <= num; i++)
//        result *= i;
//    return result;
//}

//Console.Write("Enter a number to calculate factorial: ");
//int factNum = int.Parse(Console.ReadLine());
//Console.WriteLine($"Factorial of {factNum} is: {Factorial(factNum)}");

//-------------------------------------------------------------------------------------------------------------------

//8 - Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

//using System;

//Console.WriteLine("\n8. Change Character in a String:");
//string ChangeChar(string input, int position, char newChar)
//{
//    char[] chars = input.ToCharArray();
//    chars[position] = newChar;
//    return new string(chars);
//}

//Console.Write("Enter a string: ");
//string inputString = Console.ReadLine();
//Console.Write("Enter position to change (0-based): ");
//int pos = int.Parse(Console.ReadLine());
//Console.Write("Enter new character: ");
//char newCharacter = Console.ReadLine()[0];
//Console.WriteLine("Modified string: " + ChangeChar(inputString, pos, newCharacter));


