using System;

public class Hephaestus : Demigod
{
    public float[] changeHeph(float[]a)
    {
        a[spd]=7f;
        a[swd]=9f;
        a[arc]=7f;
        a[IQ]=17f;
        a[cha]=6f;
        a[heal]=8f;
        a[str]=13f;
        a[sta]=10f;
        a[crft]=18f;
        a[stl]=8f;
        return a;
    }

    public float[] improveStatsHeph(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int m = gen.Next(1,10); // m is mechanic
        if(m<10)
        {
            b[crft]+=3f;
            b[IQ]++;
        }
        int s = gen.Next(1,10); // s is strong?
        if(s<4)
        {
            b[str]+=2f;
        }
        int i = gen.Next(1,10); // i is innovator 
        if(i<=5)
        {
            b[IQ]+=2f;
        }
        int sa = gen.Next(1,10); // sa is socially awkward
        if(sa>4)
        {
            b[stl]++;
            b[cha]-=2f;
        }
        return b;
    }
}
