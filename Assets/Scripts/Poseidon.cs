using System;

public class Poseidon : Demigod
{
    public float[] changePoseidon(float[]a)
    {
        a[spd] = 14f;
        a[swd] = 15f;
        a[arc] = 5f;
        a[IQ] = 9f;
        a[cha] = 14f;
        a[heal] = 8f;
        a[str] = 11f;
        a[sta] = 14f;
        a[crft] = 6f;
        a[stl] = 9f;
        return a;
    }
        
    public float[] improveStatsPoseidon(float[]b)
    {
        Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
        int l = gen.Next(1,10); // l is loyal
        if (l < 9)  // poseidon children tend to be more loyal
        {
            b[cha] += 2f;// because of the loyalty, they're charm is stronger on people
        }
        int sN = gen.Next(1,10); // sN is sea Navigator
        if (sN > 4)  // children of poseidon generally have a sense of where they are in water
        {
            b[IQ] += 2f; // the navigation increases there IQ
        }
        return b;
    }
}
