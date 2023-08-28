using System;

public class Demeter : Demigod
{
    public float[] changeDemeter(float[]a)
    {
        a[spd]=12f;
        a[swd]=8f;
        a[arc]=8f;
        a[IQ]=13f;
        a[cha]=8f;
        a[heal]=13f;
        a[str]=8f;
        a[sta]=13f;
        a[crft]=7f;
        a[stl]=8f;
        return a;
    }

    public float[] improveStatsDemeter(float[]a)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int b = gen.Next(1,10); // b is botanist
        if(b>3)
        {
            a[IQ]+=2f;
        }
        int mc = gen.Next(1,10); // mc is moral compass
        if(mc>1)
        {
            a[IQ]++;
            a[cha]+=3f;
        }
        return a;
    }
}
