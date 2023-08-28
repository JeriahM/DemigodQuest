using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demigod : MonoBehaviour
{
	Vector3 posit;
	public Advance next;
	public Dionysus dionysus;
	public Aphrodite aphrodite;
	public Demeter demeter;
	public Athena athena;
	public Ares ares;
	public Apollo apollo;
	public Artemis artemis;
	public Hermes hermes;
	public Hera hera;
	public Hephaestus heph;
	public Hades hades;
	public Poseidon poseidon;
	public Zeus zeus;
	public GameObject HB,swordHit1, swordHit2;
	bool attack;
	public static float[] stats = { 10f,10f,5f,10f,10f,10f,10f,12f,5f,10f };
	public int spd = 0; //speed
	public int swd = 1; //sword skills
	public int arc = 2; //archery skills
	public int IQ = 3; //intelligence
	public int cha = 5; //charm
	public int heal = 4; //healing abilities
	public int str = 6; // strength
	public int sta = 7; //stamina
	public int crft = 8; //crafting 
	public int stl = 9; //stealth
	protected string day;
	public int d=1, sceneCount;
	public static int activity=0, daytime=1, gameplay, count, style, weapon;
	public static float bonus1=0, bonus2=0, bonus3=0, speedU, SwdU, ArcU, userH;//speed, swd, arch

	void Character()
	{
		int v = UserChoice.character;
		switch(v)
		{
			case 1:
				athena=GameObject.Find("Athena Daughter@Idle").GetComponent<Athena>();
				break;
			case 2:
				athena=GameObject.Find("Athena Son@Idle").GetComponent<Athena>();
				break;
			case 3:
				ares=GameObject.Find("Ares Daughter@Idle").GetComponent<Ares>();
				break;
			case 4:
				ares=GameObject.Find("Ares Son@Idle").GetComponent<Ares>();
				break;
			case 5:
				apollo=GameObject.Find("Apollo Daughter@Idle").GetComponent<Apollo>();
				break;
			case 6:
				apollo=GameObject.Find("Apollo Son@Idle").GetComponent<Apollo>();
				break;
			case 7:
				artemis=GameObject.Find("Artemis Daughter@Idle").GetComponent<Artemis>();
				break;
			case 8:
				artemis=GameObject.Find("Artemis Son@Idle").GetComponent<Artemis>();
				break;
			case 9:
				aphrodite=GameObject.Find("Aphrodite Daughter@Idle").GetComponent<Aphrodite>();
				break;
			case 10:
				aphrodite=GameObject.Find("Aphrodite Son@Idle").GetComponent<Aphrodite>();
				break;
			case 11:
				demeter=GameObject.Find("Demeter Daughter@Idle").GetComponent<Demeter>();
				break;
			case 12:
				demeter=GameObject.Find("Demeter Son@Idle").GetComponent<Demeter>();
				break;
			case 13:
				dionysus=GameObject.Find("Dionysus Daughter@Idle").GetComponent<Dionysus>();
				break;
			case 14:
				dionysus=GameObject.Find("Dionysus Son@Idle").GetComponent<Dionysus>();
				break;
			case 15:
				hermes=GameObject.Find("Hermes Daughter@Idle").GetComponent<Hermes>();
				break;
			case 16:
				hermes=GameObject.Find("Hermes Son@Idle").GetComponent<Hermes>();
				break;
			case 17:
				hera=GameObject.Find("Hera PawnD@Idle").GetComponent<Hera>();
				break;
			case 18:
				hera=GameObject.Find("Hera PawnS@Idle").GetComponent<Hera>();
				break;
			case 19:
				heph=GameObject.Find("Hephaestus Daughter@Idle").GetComponent<Hephaestus>();
				break;
			case 20:
				heph=GameObject.Find("Hephaestus Son@Idle").GetComponent<Hephaestus>();
				break;
			case 21:
				hades=GameObject.Find("Hades Daughter@Idle").GetComponent<Hades>();
				break;
			case 22:
				hades=GameObject.Find("Hades Son@Idle").GetComponent<Hades>();
				break;
			case 23:
				poseidon=GameObject.Find("Poseidon Daughter@Idle").GetComponent<Poseidon>();
				break;
			case 24:
				poseidon=GameObject.Find("Poseidon Son@Idle").GetComponent<Poseidon>();
				break;
			case 25:
				zeus=GameObject.Find("Zeus Daughter@Idle").GetComponent<Zeus>();
				break;
			case 26:
				zeus=GameObject.Find("Zeus Son@Idle").GetComponent<Zeus>();
				break;
			default:
				dionysus=GameObject.Find("Dionysus Son@Idle").GetComponent<Dionysus>();
				//dionysus=GameObject.Find("Dionysus Daughter@Idle").GetComponent<Dionysus>();
				//aphrodite=GameObject.Find("Aphrodite Daughter@Idle").GetComponent<Aphrodite>();
				//aphrodite=GameObject.Find("Aphrodite Son@Idle").GetComponent<Aphrodite>();
				break;
		}
	}
	void Start()
	{
		Character();

		sceneCount=1;
		attack=true;
		gameplay=UserChoice.story;
		//gameplay=5;
		switch(gameplay)
		{
			case 1:
				stats=athena.changeAthena(stats);
				stats=athena.improveStatsAthena(stats);
				break;
			case 2:
				stats=ares.changeAres(stats);
				stats=ares.improveStatsAres(stats);
				break;
			case 3:
				stats=apollo.changeApollo(stats);
				stats=apollo.improveStatsApollo(stats);
				break;
			case 4:
				stats=artemis.changeArtemis(stats);
				stats=artemis.improveStatsArtemis(stats);
				break;
			case 5:
				stats=aphrodite.changeAphrodite(stats);
				stats=aphrodite.improveStatsAphro(stats);
				break;
			case 6:
				stats=demeter.changeDemeter(stats);
				stats=demeter.improveStatsDemeter(stats);
				break;
			case 7:
				stats=dionysus.changeDionysus(stats);
				stats=dionysus.improveStatsDion(stats);
				break;
			case 8:
				stats=hermes.changeHermes(stats);
				stats=hermes.improveStatsHermes(stats);
				break;
			case 9:
				stats=hera.changeHera(stats);
				stats=hera.improveStatsHera(stats);
				break;
			case 10:
				stats=heph.changeHeph(stats);
				stats=heph.improveStatsHeph(stats);
				break;
			case 11:
				stats=hades.changeHades(stats);
				stats=hades.improveStatsHades(stats);
				break;
			case 12:
				stats=poseidon.changePoseidon(stats);
				stats=poseidon.improveStatsPoseidon(stats);
				break;
			case 13:
				stats=zeus.changeZeus(stats);
				stats=zeus.improveStatsZeus(stats);
				break;
			default:
				stats=dionysus.changeDionysus(stats);
				stats=dionysus.improveStatsDion(stats);
				break;

		}
	}
	IEnumerator Damage()
	{
		userH-=(Monster.str)/6;
		Debug.Log(Monster.str);
		if(userH<0)
			userH=0;
		yield return new WaitForSeconds(2);
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name.Contains("Zombie")&&attack)
		{
			StartCoroutine(Damage());
			Debug.Log("Di immortals");
		}
	}
	void Location()
	{
		if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level One")&&sceneCount==1)
		{
			//this.transform.
			posit.Set(93.5f,12f,255.2f);
			transform.position=posit;
			sceneCount++;
			Debug.Log("hiya");
		}
	}
	private void CheckWeapon()
	{
		switch(weapon)
		{
			case 1:
				if(swordHit1.activeSelf)
					attack=false;
				else
					attack=true;
				break;
			case 2:
				if(swordHit2.activeSelf)
					attack=false;
				else
					attack=true;
				break;
			case 3:
				/*if(BowHit1.activeSelf)
					attack=false;
				else
					attack=true;*/
				break;
			case 4:
				/*if(BowHit2.activeSelf)
					attack=false;
				else
					attack=true;*/
				break;
			default:
				if(swordHit1.activeSelf)
					attack=false;
				else
					attack=true;
				break;
		}
	}
	void Update()
	{
		if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Prophecy"))
		{
			HB.SetActive(false);
			transform.localPosition.Set(0,0,0);
		}
		Location();
		CheckWeapon();
	}
}
