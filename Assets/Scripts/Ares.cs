using System;

public class Ares : Demigod
{
    public float[] changeAres(float[]a)
    {
        a[spd]=11f;
        a[swd]=20f;
        a[arc]=3f;
        a[IQ]=7f;
        a[cha]=5f;
        a[heal]=3f;
        a[str]=20f;
        a[sta]=12f;
        a[crft]=4f;
        a[stl]=6f;
        return a;
    }

    public float[] improveStatsAres(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int w = gen.Next(1,10); // w is for weapon master
        if(w>3)
        {
            b[swd]+=3f;
            b[IQ]+=3f;
            b[arc]++;
        }
        int h = gen.Next(1,10); // h is high stamina
        if(h<=6)
        {
            b[sta]+=4f;
            b[spd]++;
        }
        int i = gen.Next(1,10); // i is  
        if(i<5)
        {
            b[stl]--;
            b[IQ]-=2f;
        }
        return b;
    }
}
