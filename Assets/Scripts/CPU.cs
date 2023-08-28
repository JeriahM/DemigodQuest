public class CPU : Demigod
{

    private int sum; //variable used to max the stats of the cpu
    public CPU(int x)
    {
		switch(x) //using switch statement to use selection of god/goddess to go to certain cases which will set the user's base stats
		{
			case 1:
				Hephaestus cpu1 = new Hephaestus();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 2:
				Hermes cpu2 = new Hermes();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 3:
				Ares cpu3 = new Ares();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 4:
				Demeter cpu4 = new Demeter();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 5:
				Dionysus cpu5 = new Dionysus();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break; 
			case 6:
				Athena cpu6 = new Athena();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 7:
				Aphrodite cpu7 = new Aphrodite();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
			case 8:
				Apollo cpu8 = new Apollo();
				sum=(int)(spd+swd+arc+IQ+cha+heal+str+sta+crft+stl);
				MaxStats();
				break;
		}

	}

    public void MaxStats()
    {
        float y = 350f/(float)sum;
		stats[spd]*=y;
		stats[swd]*=y;
		stats[arc]*=y;
		stats[IQ]*=y;
		stats[cha]*=y;
		stats[heal]*=y;
		stats[str]*=y;
		stats[sta]*=y;
		stats[crft]*=y;
		stats[stl]*=y;
	}
}
