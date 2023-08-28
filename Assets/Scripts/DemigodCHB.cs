using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemigodCHB : Demigod
{
	public GameObject VB, Inf, Arch, For, CW, Arena, Art, Can, ToolSelect;
	public GameObject Quest, sword1, sword2;//, bow1, bow2;
	public Text daycount;
	private void SwdTraining()
	{
		stats[swd]+=2;
		stats[str]++;
		if(stats[str]>56)
			stats[str]=56;
		if(stats[swd]>56)
			stats[swd]=56;
		activity++;
		daytime++;
	}
	private void AnC()
	{
		stats[crft]+=2;
		stats[IQ]++;
		if(stats[crft]>56)
			stats[crft]=56;
		if(stats[IQ]>56)
			stats[IQ]=56;
		activity++;
		daytime++;
	}
	private void LavaRockwall()
	{
		stats[stl]+=2f;
		stats[sta]++;
		if(stats[stl]>56)
			stats[stl]=56;
		if(stats[sta]>56)
			stats[sta]=56;
		activity++;
		daytime++;
	}
	private void Infirmary()
	{
		stats[heal]+=2f;
		stats[cha]++;
		stats[IQ]++;
		if(stats[heal]>56)
			stats[heal]=56;
		if(stats[cha]>56)
			stats[cha]=56;
		if(stats[IQ]>56)
			stats[IQ]=56;
		activity++;
		daytime++;
	}
	private void ArcTraining()
	{
		stats[arc]+=3f;
		if(stats[arc]>56)
			stats[arc]=56;
		activity++;
		daytime++;
	}
	private void Volleyball()
	{
		stats[spd]+=2f;
		stats[stl]++;
		if(stats[spd]>56)
			stats[spd]=56;
		if(stats[stl]>56)
			stats[stl]=56;
		activity++;
		daytime++;
	}
	private void Forge()
	{
		stats[crft]+=2;
		stats[str]++;
		if(stats[str]>56)
			stats[str]=56;
		if(stats[crft]>56)
			stats[crft]=56;
		activity++;
		daytime++;
	}
	private void Canoe()
	{
		stats[sta]+=2f;
		stats[str]++;
		if(stats[sta]>56)
			stats[sta]=56;
		if(stats[str]>56)
			stats[str]=56;
		activity++;
		daytime++;
	}
	private void Tool(int x)
	{
		if(x==1)
		{
			sword1.SetActive(true);
			style=1;
			weapon=1;
			bonus1=2;
		}
		else if(x==2)
		{
			sword2.SetActive(true);
			style=1;
			weapon=2;
			bonus2=2;
		}
		else if(x==3)
		{
			//bow1.SetActive(true);
			style=2;
			weapon=3;
			bonus3=2;
		}
		else if(x==4)
		{
			//bow2.SetActive(true);
			style=2;
			weapon=4;
			bonus2=2;
		}
		ToolSelect.SetActive(false);
	}
	private void OnTriggerEnter(Collider other)
	{
		if(daytime<4&&activity<21)
		{
			if(other.gameObject.name=="VB Activator")
			{
				Debug.Log("detect");
				VB.SetActive(true);
			}
			if(other.gameObject.name=="Arena")
			{
				Debug.Log("detect");
				Arena.SetActive(true);
			}
			if(other.gameObject.name=="AnC Activator")
			{
				Debug.Log("detect");
				Art.SetActive(true);
			}
			if(other.gameObject.name=="Climbing Wall")
			{
				Debug.Log("detect");
				CW.SetActive(true);
			}
			if(other.gameObject.name=="forge Door")
			{
				Debug.Log("detect");
				For.SetActive(true);
			}
			if(other.gameObject.name=="Arch Activator")
			{
				Debug.Log("detect");
				Arch.SetActive(true);
			}
			if(other.gameObject.name=="bighouse")
			{
				Debug.Log("detect");
				Inf.SetActive(true);
			}
			if(other.gameObject.name=="Can")
			{
				Debug.Log("detect");
				Can.SetActive(true);
			}
		}
		if(daytime==4)
		{
			switch(gameplay)
			{
				case 1:
				if(other.gameObject.name=="Athena Door")
				{
					daytime=1;
				}
				break;
				case 2:
				if(other.gameObject.name=="Ares Door")
				{
					daytime=1;
				}
				break;
				case 3:
				if(other.gameObject.name=="Apollo Door")
				{
					daytime=1;
				}
				break;
				case 4:
				if(other.gameObject.name=="Artemis Door")
				{
					daytime=1;
				}
				break;
				case 5:
				if(other.gameObject.name=="Aphrodite Door")
				{
					daytime=1;
				}
				break;
				case 6:
				if(other.gameObject.name=="Demeter Door")
				{
					daytime=1;
				}
				break;
				case 7:
				if(other.gameObject.name=="Dionysus Door")
				{
					daytime=1;
				}
				break;
				case 8:
				if(other.gameObject.name=="Hermes Door")
				{
					daytime=1;
				}
				break;
				case 9:
				if(other.gameObject.name=="Hera Door")
				{
					daytime=1;
				}
				break;
				case 10:
				if(other.gameObject.name=="Heph Door")
				{
					daytime=1;
				}
				break;
				case 11:
				if(other.gameObject.name=="Hades Door")
				{
					daytime=1;
				}
				break;
				case 12:
				if(other.gameObject.name=="Poseidon Door")
				{
					daytime=1;
				}
				break;
				case 13:
				if(other.gameObject.name=="Zeus Door")
				{
					daytime=1;
				}
				break;
				default:
				if(other.gameObject.name=="Dionysus Door")
				{
					daytime=1;
					Debug.Log("detect");
				}
				break;
			}
		}
		if(d==8)
		{
			if(other.gameObject.name=="armory Door")
			{
				ToolSelect.SetActive(true);
				daytime++;
			}
			if(other.gameObject.name=="bighouse")
			{
				Quest.SetActive(false);
				daytime++;
				next.NextScene();
				DemigodCHB del = GetComponent<DemigodCHB>();
				Destroy(del);
			}
		}
	}
	private void Daycount()
	{
		d=count=(int)CHB.day+1;
		day="day "+d;
		daycount.text=day.ToString();
		if(d==8&&daytime>1)
			daycount.text="";

	}
	private void Detection()
	{
		if(VB.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				VB.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				VB.SetActive(false);
				Volleyball();
			}
		}
		if(Inf.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				Inf.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				Inf.SetActive(false);
				Infirmary();
			}
		}
		if(CW.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				CW.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				CW.SetActive(false);
				LavaRockwall();
			}
		}
		if(For.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				For.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				For.SetActive(false);
				Forge();
			}
		}
		if(Arch.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				Arch.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				Arch.SetActive(false);
				ArcTraining();
			}
		}
		if(Arena.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				Arena.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				Arena.SetActive(false);
				SwdTraining();
			}
		}
		if(Can.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				Can.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				Can.SetActive(false);
				Canoe();
			}
		}
		if(Art.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.L))
				Art.SetActive(false);
			if(Input.GetKeyDown(KeyCode.J))
			{
				Art.SetActive(false);
				AnC();
			}
		}
		if(ToolSelect.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.U))
				Tool(1);
			else if(Input.GetKeyDown(KeyCode.I))
				Tool(2);
			else if(Input.GetKeyDown(KeyCode.O))
				Tool(3);
			else if(Input.GetKeyDown(KeyCode.K))
				Tool(4);
		}
	}
	void Update()
	{
		gameplay=UserChoice.story;
		Detection();
		Daycount();
	}
}
