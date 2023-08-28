using System;

public class Artemis : Demigod
{
    public float[] changeArtemis(float[]a)
    {
        a[spd]=12f;
        a[swd]=7f;
        a[arc]=19f;
        a[IQ]=13f;
        a[cha]=6f;
        a[heal]=9f;
        a[str]=7f;
        a[sta]=18f;
        a[crft]=7f;
        a[stl]=10f;
        return a;
    }

    public float[] improveStatsArtemis(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int h = gen.Next(1,10); // h is for hunter
        if(h>3)
        {
            b[arc]++;
        }
        int t = gen.Next(1,10); // t is tracker
        if(t>8)
        {
            b[stl]+=2f;
            b[IQ]+=2f;
        }
        int n = gen.Next(1,10); // n is nature expert 
        if(n>4)
        {
            b[IQ]+=2f;
            b[stl]+=2f;
        }
        int i = gen.Next(1,10); // i is independent
        if(i<7)
        {
            b[sta]+=3f;
        }
        return b;
    }
}
