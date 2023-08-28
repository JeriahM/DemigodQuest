using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonsterCount
{
    public MonsterCount m;
    public Monster mo;
    Transform target;
    Advance adv;
    public int summonNumber;
    int cha = 5, lvl = 0, wave = 1;
    public float heal, spd;
    public static float str;
    Vector3 pos;
    Animator anim;
    void Start()
    {
        anim=GetComponent<Animator>();
        adv=GameObject.Find("Demigods").GetComponent<Advance>();
        heal=20;
        pos.Set(0,-3,0);
        transform.localPosition+=pos;
        Game();
    }
    void Level(int x)
    {
        switch(x)
        {
            case 1:
                spd=27;
                str=23-(int)Demigod.stats[cha];
                if(str<3)
                {
                    str=3;
                }
                heal=25;
                lvl=1;
                break;
            case 2:
                spd=34;
                str=30-(int)Demigod.stats[cha];
                if(str<3)
                    str=3;
                heal=30;
                lvl=2;
                break;
            case 3:
                spd=42;
                str=40-(int)Demigod.stats[cha];
                if(str<3)
                    str=3;
                heal=35;
                lvl=3;
                break;
        }
    }
    void Game()
    {
        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level One"))
            Level(1);
        else if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level Two"))
            Level(2);
        else if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level Three"))
            Level(3);
        //Level(1);
    }
    void Damage(int x)
    {
        switch(x)
        {
            case 1:
                heal-=(Demigod.SwdU)/2;
                //Debug.Log(Demigod.SwdU);
                //heal=0;
                break;
            case 2:
                heal-=Demigod.ArcU;
                break;
        }
    }
    void Spawn()
    {
        if(lvl==1)
        {
            switch(summonNumber)
            {
                case 1:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 2:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 3:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 4:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 5:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 6:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 7:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 8:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 9:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 10:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 11:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 12:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 13:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 14:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 15:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 16:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 17:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 18:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 19:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 20:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 21:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 22:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 23:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 24:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 25:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 26:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 27:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 28:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 29:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 30:
                    StartCoroutine(Summon(summonNumber));
                    break;
            }
        }
        else if(lvl==2)
        {
            switch(summonNumber)
            {
                case 1:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 2:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 3:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 4:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 5:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 6:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 7:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 8:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 9:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 10:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 11:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 12:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 13:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 14:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 15:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 16:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 17:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 18:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 19:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 20:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 21:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 22:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 23:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 24:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 25:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 26:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 27:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 28:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 29:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 30:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 31:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 32:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 33:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 34:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 35:
                    StartCoroutine(Summon(summonNumber));
                    break;
            }
        }
        else if(lvl==3)
        {
            switch(summonNumber)
            {
                case 1:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 2:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 3:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 4:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 5:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 6:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 7:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 8:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 9:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 10:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 11:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 12:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 13:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 14:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 15:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 16:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 17:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 18:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 19:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 20:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 21:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 22:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 23:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 24:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 25:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 26:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 27:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 28:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 29:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 30:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 31:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 32:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 33:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 34:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 35:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 36:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 37:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 38:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 39:
                    StartCoroutine(Summon(summonNumber));
                    break;
                case 40:
                    StartCoroutine(Summon(summonNumber));
                    break;
            }
        }
    }
    IEnumerator Summon(int x)
    {
        if(x<16)
        {
            yield return new WaitForSeconds(3f);
            if(pos.y<0)
            {
                pos.y=3;
                transform.localPosition+=pos;
                m.mCount++;
            }
            mo.wave=2;
        }
        else if(x<21&&mo.wave==2)
        {
            yield return new WaitForSeconds(30);
            if(m.mCount<15)
            {
                switch(m.mCount)
                {
                    case 14:
                        if(x==16)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 13:
                        if(x==16||x==17)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 12:
                        if(x==16||x==17||x==18)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 11:
                        if(x==16||x==17||x==18||x==19)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 10:
                        if(x==16||x==17||x==18||x==19||x==20)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    default:
                        if(m.mCount!=15)
                        {
                            if(x==16||x==17||x==18||x==19||x==20)
                            {
                                if(pos.y<0)
                                {
                                    pos.y=3;
                                    transform.localPosition+=pos;
                                    m.mCount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
        else if(x<26&&mo.wave==3)
        {
            yield return new WaitForSeconds(30);
            if(m.mCount<15)
            {
                switch(m.mCount)
                {
                    case 14:
                        if(x==21)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 13:
                        if(x==21||x==22)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 12:
                        if(x==21||x==22||x==23)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 11:
                        if(x==21||x==22||x==23||x==24)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 10:
                        if(x==21||x==22||x==23||x==24||x==25)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    default:
                        if(m.mCount!=15)
                        {
                            if(x==21||x==22||x==23||x==24||x==25)
                            {
                                if(pos.y<0)
                                {
                                    pos.y=3;
                                    transform.localPosition+=pos;
                                    m.mCount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
        else if(x<31&&mo.wave==4)
        {
            yield return new WaitForSeconds(30);
            if(m.mCount<15)
            {
                switch(m.mCount)
                {
                    case 14:
                        if(x==26)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 13:
                        if(x==26||x==27)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 12:
                        if(x==26||x==27||x==28)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 11:
                        if(x==26||x==27||x==28||x==29)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 10:
                        if(x==26||x==27||x==28||x==29||x==30)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    default:
                        if(m.mCount!=15)
                        {
                            if(x==26||x==27||x==28||x==29||x==30)
                            {
                                if(pos.y<0)
                                {
                                    pos.y=3;
                                    transform.localPosition+=pos;
                                    m.mCount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
        else if(x<36&&mo.wave==5)
        {
            yield return new WaitForSeconds(30);
            if(m.mCount<15)
            {
                switch(m.mCount)
                {
                    case 14:
                        if(x==31)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 13:
                        if(x==31||x==32)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 12:
                        if(x==31||x==32||x==33)
                        {
                           if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 11:
                        if(x==31||x==32||x==33||x==34)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 10:
                        if(x==31||x==32||x==33||x==34||x==35)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    default:
                        if(m.mCount!=15)
                        {
                            if(x==31||x==32||x==33||x==34||x==35)
                            {
                                if(pos.y<0)
                                {
                                    pos.y=3;
                                    transform.localPosition+=pos;
                                    m.mCount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
        else if(x<41&&mo.wave==6)
        {
            yield return new WaitForSeconds(30);
            if(m.mCount<15)
            {
                switch(m.mCount)
                {
                    case 14:
                        if(x==36)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 13:
                        if(x==36||x==37)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 12:
                        if(x==36||x==37||x==38)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 11:
                        if(x==36||x==37||x==38||x==39)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    case 10:
                        if(x==36||x==37||x==38||x==39||x==40)
                        {
                            if(pos.y<0)
                            {
                                pos.y=3;
                                transform.localPosition+=pos;
                                m.mCount++;
                            }
                        }
                        break;
                    default:
                        if(m.mCount!=15)
                        {
                            if(x==36||x==37||x==38||x==39||x==40)
                            {
                                if(pos.y<0)
                                {
                                    pos.y=3;
                                    transform.localPosition+=pos;
                                    m.mCount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
    void Die()
    {
        if(heal<=0)
        {
            this.gameObject.SetActive(false);
            m.mCount--;
            Debug.Log("Another one bites the dust");
            if(summonNumber==15)
                mo.wave=2;
            if(summonNumber==20)
                mo.wave=3;
            if(summonNumber==25)
                mo.wave=4;
            if(summonNumber==30)
                mo.wave=5;
            if(summonNumber==35)
                mo.wave=6;
            if(summonNumber==30&&SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level One"))
                adv.NextScene();
            if(summonNumber==35&&SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level Two"))
                adv.NextScene();
            if(summonNumber==40&&SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Level Three"))
                adv.NextScene();
        }
    }
    void Move()
    {
        int character = UserChoice.character;
        switch(character)
        {
            case 1:
                target=GameObject.Find("AthenaD").transform;
                transform.LookAt(target.position);
                break;
            case 2:
                target=GameObject.Find("AthenaS").transform;
                transform.LookAt(target.position);
                break;
            case 3:
                target=GameObject.Find("AresD").transform;
                transform.LookAt(target.position);
                break;
            case 4:
                target=GameObject.Find("AresS").transform;
                transform.LookAt(target.position);
                break;
            case 5:
                target=GameObject.Find("ApolloD").transform;
                transform.LookAt(target.position);
                break;
            case 6:
                target=GameObject.Find("ApolloS").transform;
                transform.LookAt(target.position);
                break;
            case 7:
                target=GameObject.Find("ArtemisH").transform;
                transform.LookAt(target.position);
                break;
            case 8:
                target=GameObject.Find("ArtemisF").transform;
                transform.LookAt(target.position);
                break;
            case 9:
                target=GameObject.Find("AphroditeD").transform;
                transform.LookAt(target.position);
                break;
            case 10:
                target=GameObject.Find("AphroditeS").transform;
                transform.LookAt(target.position);
                break;
            case 11:
                target=GameObject.Find("DemeterD").transform;
                transform.LookAt(target.position);
                break;
            case 12:
                target=GameObject.Find("DemeterS").transform;
                transform.LookAt(target.position);
                break;
            case 13:
                target=GameObject.Find("DionysusD").transform;
                transform.LookAt(target.position);
                break;
            case 14:
                target=GameObject.Find("DionysusS").transform;
                transform.LookAt(target.position);
                break;
            case 15:
                target=GameObject.Find("HermesD").transform;
                transform.LookAt(target.position);
                break;
            case 16:
                target=GameObject.Find("HermesS").transform;
                transform.LookAt(target.position);
                break;
            case 17:
                target=GameObject.Find("HeraD").transform;
                transform.LookAt(target.position);
                break;
            case 18:
                target=GameObject.Find("HeraS").transform;
                transform.LookAt(target.position);
                break;
            case 19:
                target=GameObject.Find("HephD").transform;
                transform.LookAt(target.position);
                break;
            case 20:
                target=GameObject.Find("HephS").transform;
                transform.LookAt(target.position);
                break;
            case 21:
                target=GameObject.Find("HadesD").transform;
                transform.LookAt(target.position);
                break;
            case 22:
                target=GameObject.Find("HadesS").transform;
                transform.LookAt(target.position);
                break;
            case 23:
                target=GameObject.Find("PoseidonD").transform;
                transform.LookAt(target.position);
                break;
            case 24:
                target=GameObject.Find("PoseidonS").transform;
                transform.LookAt(target.position);
                break;
            case 25:
                target=GameObject.Find("ZeusD").transform;
                transform.LookAt(target.position);
                break;
            case 26:
                target=GameObject.Find("ZeusS").transform;
                transform.LookAt(target.position);
                break;
            default:
                target=GameObject.Find("DionysusS").transform;
                transform.LookAt(target.position);
                break;
        }
        if(pos.y<=-1)
            anim.SetBool("Walk",false);
        else
            anim.SetBool("Walk",true);
        anim.speed=spd/45;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="swordhit1")
        {
            Damage(1);
            Debug.Log("Owie");
        }
        if(other.gameObject.name=="swordhit2")
            Damage(1);
        /*if(other.gameObject.name=="bowhit1")
            Damage(1);
        if(other.gameObject.name=="bowhit2")
            Damage(1);
        if(other.gameObject.name=="arrow1")
            Damage(2);
        if(other.gameObject.name=="arrow2")
            Damage(2);*/
    }
    void Update()
    {
        Spawn();
        Move();
        Die();
    }
}
