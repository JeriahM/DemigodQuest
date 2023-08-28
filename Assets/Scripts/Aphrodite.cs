using System;

public class Aphrodite : Demigod
{
    public float[] changeAphrodite(float[]a)
    {
        a[spd]=7f;
        a[swd]=6f;
        a[arc]=6f;
        a[IQ]=9f;
        a[cha]=17f;
        a[heal]=14f;
        a[str]=5f;
        a[sta]=12f;
        a[crft]=7f;
        a[stl]=9f;
        return a;
    }

    public float[] improveStatsAphro(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int ego = gen.Next(1,10); 
        if(ego>6)
        {
            b[cha]--;
            b[IQ]-=2f;
        }
        int e = gen.Next(1,10); // e is equestrian
        if(e>=6)  
        {
            b[sta]+=2f;
            b[spd]++;
        }
        int g = gen.Next(1,10); // g is gorgeous 
        if(g>1)
        {
            b[cha]+=2f;
        }
        int c = gen.Next(1,10); // c is charmspeak
        if(c<3)  
        {
            b[cha]+=2f;
            b[IQ]++;
        }
        int h = gen.Next(1,10); // h is 
        if(h>4)
        {
            b[IQ]+=3f;
        }
        return b;
    }
}
