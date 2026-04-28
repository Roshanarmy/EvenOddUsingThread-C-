
// Print Even odd number using multithread or lock

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

public class EvenOddUsingThread
{
    static int max = 10; //yaha static nahi likhne se errror aayega for me because if its non static but 
    //method is staic where we are using for loop;
    static object lockobject = new object();
    public static void PrintEven()
    {
        for(int i=1; i< max ; i++)
        {
            lock(lockobject)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("Even NO :- " + i);
                }
            }
            
        }

    }
    public static void PrintOdd()
    {
        for(int i=1; i< max ; i++)
        {
            lock(lockobject)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine("Odd NO :- " + i);
                }
            }
            
        }
        
    }
    public static void Run2()
    {
        Thread t1 = new Thread (PrintEven);
        Thread t2 = new Thread (PrintOdd);
        t1.Start();
        t2.Start();

    }
}