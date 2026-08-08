using System;
using System.Diagnostics.Metrics;
using System.Numerics;
class gRandom {

    private static int counter = 0 ;private static int snumbers = 0; static int mmax = 0;static int mmin = 0;
    public static void writer() 
    {
        Random random = new Random();
        int i = mmax - mmin;
        int ii = random.Next(i);
        ii = ii + mmin;
        String s= ii.ToString();
        if (counter != 0) Console.Write(" , ");
        Console.Write(s);
        
    
    }
    public static void randomLoop(int n,int mins, int maxs)
    {
        mmax = maxs;
        mmin = mins;
        //Console.WriteLine(mmax);
        //Console.WriteLine(mmin);
        Console.Write("int[] n ={ ");
        for (int i = 0; i < n; i++)

        {
            writer();
            counter++;
        }
        Console.WriteLine(" } ;");
    }



}



class genRandom {

    public static void Main() 
    
    
    { 
    
    
    
        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.Clear();
        gRandom.randomLoop(60,1,50);
    
    
    
    }






}

