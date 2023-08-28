using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    public int gameplay, character;
    public GameObject mrD, AthenaI, AresI, ApolloI, ArtemisI, AphroI, DemeterI;
    public GameObject HermesI, HeraI, HephI, HadesI, PoseidonI, ZeusI;
    public GameObject AthenaS, AthenaD, AphroditeS, AphroditeD, AresS, AresD;
    public GameObject ApolloS, ApolloD, ArtemisS, ArtemisD, DionysusS, DionysusD;
    public GameObject DemeterS, DemeterD, HermesS, HermesD, HephaestusS, HephaestusD;
    public GameObject ZeusS, ZeusD, PoseidonS, PoseidonD, HadesS, HadesD, HeraS, HeraD;
    //public int item;
    // Start is called before the first frame update
    void Start()
    {
        gameplay=UserChoice.story;
        character=UserChoice.character;
    }

    public void Claiming()
    {
        switch(gameplay)
        {
            case 1:
                AthenaI.SetActive(true);
                if(character==1)
                    AthenaD.SetActive(true);
                else
                    AthenaS.SetActive(true);   
                break;
            case 2:
                AresI.SetActive(true);
                if(character==3)
                    AresD.SetActive(true);
                else
                    AresS.SetActive(true);
                break;
            case 3:
                ApolloI.SetActive(true);
                if(character==5)
                    ApolloD.SetActive(true);
                else
                    ApolloS.SetActive(true);
                break;
            case 4:
                ArtemisI.SetActive(true);
                if(character==7)
                    ArtemisD.SetActive(true);
                else
                    ArtemisS.SetActive(true);
                break;
            case 5:
                AphroI.SetActive(true);
                if(character==9)
                    AphroditeD.SetActive(true);
                else
                    AphroditeS.SetActive(true);
                break;
            case 6:
                DemeterI.SetActive(true);
                if(character==11)
                    DemeterD.SetActive(true);
                else
                    DemeterS.SetActive(true);
                break;
            case 7:
                mrD.SetActive(true);
                if(character==13)
                    DionysusD.SetActive(true);
                else
                    DionysusS.SetActive(true);
                break;
            case 8:
                HermesI.SetActive(true);
                if(character==15)
                    HermesD.SetActive(true);
                else
                    HermesS.SetActive(true);
                break;
            case 9:
                HeraI.SetActive(true);
                if(character==17)
                    HeraD.SetActive(true);
                else
                    HeraS.SetActive(true);
                break;
            case 10:
                HephI.SetActive(true);
                if(character==19)
                HephaestusD.SetActive(true);
                else
                    HephaestusS.SetActive(true);
                break;
            case 11:
                HadesI.SetActive(true);
                if(character==21)
                    HadesD.SetActive(true);
                else
                    HadesS.SetActive(true);
                break;
            case 12:
                PoseidonI.SetActive(true);
                if(character==23)
                    PoseidonD.SetActive(true);
                else
                    PoseidonS.SetActive(true);
                break;
            case 13:
                ZeusI.SetActive(true);
                if(character==25)
                    ZeusD.SetActive(true);
                else
                    ZeusS.SetActive(true);
                break;
            default:
                mrD.SetActive(true);
                DionysusS.SetActive(true);
                break;
        }
    }
}
