using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHB : MonoBehaviour
{
    public int gameplay, character, activity, daytime;
    int y = 0;
    public static float count, day;
    //public Demigod user;
    public GameObject l1, l2, l3;
    
    public GameObject AthenaS, AthenaD, AphroditeS, AphroditeD, AresS, AresD;
    public GameObject ApolloS, ApolloD, ArtemisS, ArtemisD, DionysusS, DionysusD;
    public GameObject DemeterS, DemeterD, HermesS, HermesD, HephaestusS, HephaestusD;
    public GameObject ZeusS, ZeusD, PoseidonS, PoseidonD, HadesS, HadesD, HeraS, HeraD;
    public GameObject VB, Arena, AnC, CW, Forge, Armory, Archery, BHnI, Canoe;
    public GameObject DZeus, DPoseidon, DHades, DHera, DHermes, DDionysus, DAthena, DDemeter, DAres, DApollo, DArtemis, DAphrodite, DHeph;
    public GameObject GArmory, ToolSelect, Quest;// Prophecy;
    // Start is called before the first frame update
    void Start()
    {
        AthenaD.SetActive(false);
        AthenaS.SetActive(false);
        AresD.SetActive(false);
        AresS.SetActive(false);
        ApolloD.SetActive(false);
        ApolloS.SetActive(false);
        ArtemisD.SetActive(false);
        ArtemisS.SetActive(false);
        AphroditeD.SetActive(false);
        AphroditeS.SetActive(false);
        DemeterD.SetActive(false);
        DemeterS.SetActive(false);
        DionysusD.SetActive(false);
        DionysusS.SetActive(false);
        HermesD.SetActive(false);
        HermesS.SetActive(false);
        HeraD.SetActive(false);
        HeraS.SetActive(false);
        HephaestusD.SetActive(false);
        HephaestusS.SetActive(false);
        HadesD.SetActive(false);
        HadesS.SetActive(false);
        PoseidonD.SetActive(false);
        PoseidonS.SetActive(false);
        ZeusD.SetActive(false);
        ZeusS.SetActive(false);
    }
    private void Story()
    {
        activity=Demigod.activity;
        count=activity/3;
        if(day==7)
        {
            Weapon();
            BigHouse();
        }
        if(count==1||count==2||count==3||count==4||count==5||count==6||count==7)
        { 
            switch(gameplay)
            {
                case 1:
                    Athena();
                    break;
                case 2:
                    Ares();
                    break;
                case 3:
                    Apollo();
                    break;
                case 4:
                    Artemis();
                    break;
                case 5:
                    Aphrodite();
                    break;
                case 6:
                    Demeter();
                    break;
                case 7:
                    Dionysus();
                    break;
                case 8:
                    Hermes();
                    break;
                case 9:
                    Hera();
                    break;
                case 10:
                    Heph();
                    break;
                case 11:
                    Hades();
                    break;
                case 12:
                    Poseidon();
                    break;
                case 13:
                    Zeus();
                    break;
                default:
                    Dionysus();
                    break;
            }
        }
    }
    private void Athena()
    {
        if(daytime==4)
            DAthena.SetActive(true);
        if(daytime==1)
            DAthena.SetActive(false);
        if(daytime==2)
            DAthena.SetActive(false);
        if(daytime==3)
            DAthena.SetActive(false);
    }
    private void Ares()
    {
        if(daytime==4)
            DAres.SetActive(true);
        if(daytime==1)
            DAres.SetActive(false);
        if(daytime==2)
            DAres.SetActive(false);
        if(daytime==3)
            DAres.SetActive(false);
    }
    private void Apollo()
    {
        if(daytime==4)
            DApollo.SetActive(true);
        if(daytime==1)
            DApollo.SetActive(false);
        if(daytime==2)
            DApollo.SetActive(false);
        if(daytime==3)
            DApollo.SetActive(false);
    }
    private void Artemis()
    {
        if(daytime==4)
            DArtemis.SetActive(true);
        if(daytime==1)
            DArtemis.SetActive(false);
        if(daytime==2)
            DArtemis.SetActive(false);
        if(daytime==3)
            DArtemis.SetActive(false);
    }
    private void Aphrodite()
    {
        if(daytime==4)
            DAphrodite.SetActive(true);
        if(daytime==1)
            DAphrodite.SetActive(false);
        if(daytime==2)
            DAphrodite.SetActive(false);
        if(daytime==3)
            DAphrodite.SetActive(false);
    }
    private void Demeter()
    {
        if(daytime==4)
            DDemeter.SetActive(true);
        if(daytime==1)
            DDemeter.SetActive(false);
        if(daytime==2)
            DDemeter.SetActive(false);
        if(daytime==3)
            DDemeter.SetActive(false);
    }
    private void Dionysus()
    {
        if(daytime==4)
            DDionysus.SetActive(true);
        if(daytime==1)
            DDionysus.SetActive(false);
        if(daytime==2)
            DDionysus.SetActive(false);
        if(daytime==3)
            DDionysus.SetActive(false);
    }
    private void Hermes()
    {
        if(daytime==4)
            DHermes.SetActive(true);
        if(daytime==1)
            DHermes.SetActive(false);
        if(daytime==2)
            DHermes.SetActive(false);
        if(daytime==3)
            DHermes.SetActive(false);
    }
    private void Hera()
    {
        if(daytime==4)
            DHera.SetActive(true);
        if(daytime==1)
            DHera.SetActive(false);
        if(daytime==3)
            DHera.SetActive(false);
        if(daytime==2)
            DHera.SetActive(false);
    }
    private void Heph()
    {
        if(daytime==4)
            DHeph.SetActive(true);
        if(daytime==1)
            DHeph.SetActive(false);
        if(daytime==2)
            DHeph.SetActive(false);
        if(daytime==3)
            DHeph.SetActive(false);
    }
    private void Hades()
    {
        if(daytime==4)
            DHades.SetActive(true);
        if(daytime==1)
            DHades.SetActive(false);
        if(daytime==2)
            DHades.SetActive(false);
        if(daytime==3)
            DHades.SetActive(false);
    }
    private void Poseidon()
    {
        if(daytime==4)
            DPoseidon.SetActive(true);
        if(daytime==1)
            DPoseidon.SetActive(false);
        if(daytime==2)
            DPoseidon.SetActive(false);
        if(daytime==3)
            DPoseidon.SetActive(false);
    }
    private void Zeus()
    {
        if(daytime==4)
            DZeus.SetActive(true);
        if(daytime==1)
            DZeus.SetActive(false);
        if(daytime==2)
            DZeus.SetActive(false);
        if(daytime==3)
            DZeus.SetActive(false);
    }

    private void Weapon()
    {
        if(daytime==1)
            GArmory.SetActive(true);
        else
            GArmory.SetActive(false);
    }
    private void DayLight()
    {
        daytime=Demigod.daytime;
        if(daytime==1)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(false);
        }
        else if(daytime==2)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(true);
        }
        else if(daytime==3)
        {
            l1.SetActive(true);
            l2.SetActive(false);
            l3.SetActive(true);
        }
        else if(daytime==4)
        {
            l1.SetActive(false);
            l2.SetActive(false);
            l3.SetActive(true);
        }
        if(daytime==1)
            day=count;
            //day=7;
    }

    private void BigHouse()
    {
        if(daytime==2)
            Quest.SetActive(true);
        else
        {
            Quest.SetActive(false);
        }
    }
    void Update()
    {
        Character();
        DayLight();
        Story();
    }
    void Character()
    {
        gameplay=Please.g;
        character=Please.c;
        if(y==0)
        {
            switch(gameplay)
            {
            case 1:
                if(character==2)
                {
                    AthenaS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    AthenaD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 2:
                if(character==4)
                {
                    AresS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    AresD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 3:
                if(character==6)
                {
                    ApolloS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    ApolloD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 4:
                if(character==8)
                {
                    ArtemisS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    ArtemisD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 5:
                if(character==10)
                {
                    AphroditeS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    AphroditeD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 6:
                if(character==12)
                {
                    DemeterS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    DemeterD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 7:
                if(character==14)
                {
                    DionysusS.SetActive(true);
                    y=1;
                }
                else
                {
                    DionysusD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 8:
                if(character==16)
                {
                    HermesS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    HermesD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 9:
                if(character==18)
                {
                    HeraS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    HeraD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
            break;
            case 10:
                if(character==20)
                {
                    HephaestusS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    HephaestusD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 11:
                if(character==22)
                {
                    HadesS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    HadesD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 12:
                if(character==24)
                {
                    PoseidonS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    PoseidonD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
            case 13:
                if(character==26)
                {
                    ZeusS.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                else
                {
                    ZeusD.SetActive(true);
                    y=1;
                    DionysusS.SetActive(false);
                }
                break;
                default:
                    DionysusS.SetActive(true);
                    break;
            }
            //Debug.Log("hope");
        }
    }
}
