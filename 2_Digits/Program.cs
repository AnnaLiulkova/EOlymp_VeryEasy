using System;

class Solution

{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int[] a=new int[n.ToString().Length];
        int count=0;
        if(0<=n && n<=2*Math.Pow(10,9))
        {
            for(int i=0; i<a.Length; i++)
            {
                a[i]=n%10;
                n /= 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}