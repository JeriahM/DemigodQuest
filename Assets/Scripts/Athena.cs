using System;

public class Athena : Demigod
{
    public float[] changeAthena(float[]a)
    {
        a[spd]=11f;
        a[swd]=13f;
        a[arc]=10f;
        a[IQ]=19f;
        a[cha]=4f;
        a[heal]=4f;
        a[str]=7f;
        a[sta]=14f;
        a[crft]=12f;
        a[stl]=7f;
        return a;
    }

    public float[] improveStatsAthena(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int w = gen.Next(1,10); // w is wise
        if(w<=6)
        {
            b[IQ]++;
        }
        int c = gen.Next(1,10); // c is clever
        if(c<=4)
        {
            b[IQ]+=2f;
            b[crft]++;
        }
        int s = gen.Next(1,10); // s is strategist 
        if(s>5)
        {
            b[IQ]++;
            b[swd]++;
            b[arc]++;
        }
        int d = gen.Next(1,10); // d is defender
        if(d>7)
        {
            b[IQ]++;
            b[swd]++;
            b[arc]++;
        }
        int l = gen.Next(1,10); // l is leader
        if(l>=8)
        {
            b[IQ]+=2f;
            b[swd]+=3f;
        }
        int cr = gen.Next(1,10); // cr is crafter
        if(cr<=6)
        {
            b[crft]+=3f;
        }
        int h = gen.Next(1,10); //h is hubris
        if(h<8)
        {
            b[IQ]-=3f;
            b[cha]-=2f;
        }
        return b;
    }
}
