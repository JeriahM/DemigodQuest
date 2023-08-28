using System;



public class Zeus : Demigod
    {
        public float[] changeZeus(float[]a) 
        {
            a[spd] = 13f;
            a[swd] = 15f;
            a[arc] = 8f;
            a[IQ] = 13f;
            a[cha] = 12f;
            a[heal] = 5f;
            a[str] = 13f;
            a[sta] = 17f;
            a[crft] = 5f;
            a[stl] = 2f;
            return a;
        }

        public float[] improveStatsZeus(float[]b) 
        {
            Random gen = new Random(); // a random number generator that will be in subclasses when determining the qualities passed down by chosen god/goddess
            int l = gen.Next(1,10); // l is leaders
            if (l > 2)  // a greater chance that zeus's kids are leaders
            {
                b[IQ] += 2f; // leader means higher IQ and charm
                b[cha] += 3f;
            }
            int h = gen.Next(1,10); // h is hesitant
            if (h > 2)  // a greater chance that zeus's kids are more hesitant because they live to higher expectations 
            {
                b[spd] --; // being hesitant causes them to act slower, lowering there speed
            }
            return b;
        }
    
    }

