using System;

public class Hermes : Demigod
{
    public float[] changeHermes(float[]a)
    {
        a[spd]=14f;
        a[swd]=8f;
        a[arc]=7f;
        a[IQ]=9f;
        a[cha]=10f;
        a[heal]=6f;
        a[str]=8f;
        a[sta]=12f;
        a[crft]=9f;
        a[stl]=16f;
        return a;
    }

    public float[] improveStatsHermes(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int lb = gen.Next(1,10); // lb is laid back
        if(lb>2)  
        {
            b[cha]++;// because of their personality, they're charm is stronger on people and are more stealthy
            b[stl]++;
        }
        int s = gen.Next(1,10); // s is stealthy
        if(s>6)  //Hermes god of thiefs
        {
            b[stl]+=3f; 
        }
        int a = gen.Next(1,10); // a is 
        if(a>2)
        {
            b[cha]++;
            b[stl]+=2f;
            b[IQ]++;
        }
        int c = gen.Next(1,10); // c is communicator
        if(c>6)  //Hermes god of thiefs
        {
            b[cha]+=3f;
        }
        return b;
    }
}
