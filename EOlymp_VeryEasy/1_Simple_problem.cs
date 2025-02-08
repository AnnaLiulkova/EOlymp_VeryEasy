using System;

class Solution
{
    public static void Main(string[] args)
    {
        int two_digit = int.Parse(Console.ReadLine());
        if(two_digit>=10 && two_digit<=99)
        {
            int first_d = two_digit / 10;
            int second_d = two_digit % 10;
            Console.WriteLine($"{first_d} {second_d}");
        }
    }
}
