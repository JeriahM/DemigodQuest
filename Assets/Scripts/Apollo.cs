using System;

public class Apollo : Demigod
{
    public float[] changeApollo(float[]a)
    {
        a[spd]=11f;
        a[swd]=4f;
        a[arc]=20f;
        a[IQ]=10f;
        a[cha]=13f;
        a[heal]=15f;
        a[str]=8f;
        a[sta]=8f;
        a[crft]=3f;
        a[stl]=4f;
        return a;
    }

    public float[] improveStatsApollo(float[] b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int h = gen.Next(1,10); // h is for healer
        if(h<=6)
        {
            b[heal]+=3f;
        }
        int m = gen.Next(1,10); // m is musician
        if(m<4)  
        {
            b[cha]+=2f;
            b[IQ]++;
        }
        int p = gen.Next(1,10); // p is poet 
        if(p==7)
        {
            b[stl]--;
            b[cha]+=2f;
        }
        int P = gen.Next(1,10); // P is phrophet
        if(P==7)  
        {
            b[IQ]+=4f;
        }
        int ego = gen.Next(1,10);
        if(ego>6)
        {
            b[IQ]-=2f;
            b[cha]--;
        }
        return b;
    }
}
