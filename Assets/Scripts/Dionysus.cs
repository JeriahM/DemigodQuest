using System;
using UnityEngine;

public class Dionysus : Demigod
{
    public float[] changeDionysus(float[]a)
    {
        a[spd]=11f;
        a[swd]=9f;
        a[arc]=9f;
        a[IQ]=7f;
        a[cha]=12f;
        a[heal]=13f;
        a[str]=8f;
        a[sta]=12f;
        a[crft]=6f;
        a[stl]=11f;
        return a;
    }

    public float[] improveStatsDion(float[]b)
    {
        System.Random gen = new System.Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int a = gen.Next(1,10); // a is actor
        if(a>3)
        {
            b[cha]++;
            b[stl]+=2f;
        }
        int c = gen.Next(1,10); // c is communicator
        if(c>4)
        {
            b[cha]+=3f;
        }
        int lb = gen.Next(1,10); // l is laid back
        if(lb>2)
        {
            b[stl]++;
            b[cha]++;
        }
        return b;
    }
}
