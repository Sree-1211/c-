// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter numbers:\n");
        int a,b;
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        
        int temp=a;
        a=b;
        b=temp;
        Console.WriteLine("1st swap. num1:"+a+"\tnum1:"+b);
        a=a^b;
        b=a^b;
        a=a^b;
        Console.WriteLine("2nd swap. num1:"+a+"\tnum1:"+b);
        
        (a,b)=(b,a);
        Console.WriteLine("3d swap. num1:"+a+"\tnum1:"+b);
        
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine("4th swap. num1:"+a+"\tnum1:"+b);
    }
}
