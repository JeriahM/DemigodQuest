using System;

public class Satyr : Demigod
{
    Random gen = new Random();
    private int age;
    public float[] changeSatyr(float[]b)
    {
        b[spd]=34f;
        b[swd]=23f;
        b[arc]=20f;
        b[IQ]=34f;
        b[cha]=34f;
        b[heal]=30f;
        b[str]=29f;
        b[sta]=37f;
        b[crft]=28f;
        b[stl]=30f;
        int a = (int)gen.NextDouble()*10+1;
        if(a<5)
            age=60;
        else
            age=28;
        return b;
    }

    public float[] improveStatsSatyr(float[] b)
    {
        int wm = (int)gen.NextDouble()*10+1; //wm is woodland music
        if(wm<7)
            b[IQ]+=4f;
        if(age>30)
        {
            b[stl]+=2f;
            b[IQ]+=2f;
        }
        else
        {
            b[spd]++;
            b[cha]++;
            b[str]++;
        }
        return b;
    }
}
