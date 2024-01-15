using System;

class Program
{
    static void Main()
    {
        // Accept input array from the user
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] input1 = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            input1[i] = int.Parse(Console.ReadLine());
        }

        // Accept input2 from the user
        Console.Write("Enter the value of input2: ");
        int input2 = int.Parse(Console.ReadLine());

        int[] resultArray = PrimeEncoder(input1, input2);

        Console.WriteLine("\nResult Array: " + string.Join(", ", resultArray));
    }

    static int[] PrimeEncoder(int[] input1, int input2)
    {
        // Find the nth prime number
        int nthPrime = FindNthPrime(input2);

        // Add the nth prime to each element in the array
        for (int i = 0; i < input1.Length; i++)
        {
            input1[i] += nthPrime;
        }

        return input1;
    }

    static int FindNthPrime(int n)
    {
        int count = 0;
        int number = 2;

        while (true)
        {
            if (IsPrime(number))
            {
                count++;
                if (count == n)
                {
                    return number;
                }
            }

            number++;
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
