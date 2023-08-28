using System;

public class Hera : Demigod
{
    public float[] changeHera(float[]a)
    {
        a[spd]=7f;
        a[swd]=8f;
        a[arc]=8f;
        a[IQ]=16f;
        a[cha]=13f;
        a[heal]=11f;
        a[str]=7f;
        a[sta]=8f;
        a[crft]=5f;
        a[stl]=10f;
        return a;
    }

    public float[] improveStatsHera(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int l = gen.Next(1,10); // h is for healer
        if(l<4)
        {
            b[cha]+=3f;
            b[IQ]+=2f;
        }
        int c = gen.Next(1,10); // c is communicator
        if(c>4)
        {
            b[cha]+=3f;
        }
        int d = gen.Next(1,10); // d is deceitful 
        if(d>3)
        {
            b[cha]--;
            b[stl]+=2f;
        }
        int i = gen.Next(1,10); // i is 
        if(i>7)
        {
            b[IQ]+=2f;
        }
        int n = gen.Next(1,10); // n is
        if(n<8)
        {
            b[IQ]+=2f;
        }
        int m = gen.Next(1,10); // m is 
        if(m>2)
        {
            b[heal]+=2f;
        }
        return b;
    }
}
