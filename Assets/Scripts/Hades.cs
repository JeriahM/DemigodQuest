using System;

public class Hades : Demigod
{
    public float[] changeHades(float[]a)
    {
        a[spd]=13f;
        a[swd]=14f;
        a[arc]=9f;
        a[IQ]=10f;
        a[cha]=6f;
        a[heal]=8f;
        a[str]=10f;
        a[sta]=14f;
        a[crft]=8f;
        a[stl]=18f;
        return a;
    }

    public float[] improveStatsHades(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int g = gen.Next(1,10); // g is grudgeful
        if(g<=6)
        {
            b[IQ]-=2f;
        }
        return b;
    }
}
