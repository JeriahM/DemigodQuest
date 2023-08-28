using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject user;
    public GameObject swordHit1, swordHit2, BowHit1, BowHit2, Arrow;
    public int weapon, temp;
    Vector3 rotator, rotateSword1, rotateSword2, origin2, p1, p2;
    // Start is called before the first frame update
    void Start()
    {
        //set rotator for all weapons
        temp=0;
        rotator.Set(0,0,0);
        //Variables used for the sword attack of the second sword
        rotateSword1.Set(30,45,0);
        rotateSword2.Set(49.942f,274.368f,51.284f);
        origin2.Set(0,0,0);
        p1.Set(0.2240009f,1.383f,0.3809814f);
        p2.Set(-.177f,1.102f,.485f);
    }
    private void Shot()
    {
        weapon=Demigod.weapon;
        switch(weapon)
        {
            case 3:
                break;
            case 4:
                break;
        }
    }
    private void Hit()
    {
        weapon=Demigod.weapon;
        //weapon=1;
        switch(weapon)
        {
            case 1:
                StartCoroutine(SwordOne());
                break;
            case 2:
                StartCoroutine(SwordTwo());
                break;
            case 3:
                StartCoroutine(BowOne());
                break;
            case 4:
                StartCoroutine(BowTwo());
                break;
        }

    }
    IEnumerator SwordOne()
    {
        if(Input.GetMouseButtonDown(0))
        {
            swordHit1.SetActive(true);
            Debug.Log("Swing");
            yield return new WaitForSeconds(.15f);
            transform.localEulerAngles-=rotateSword1;
            yield return new WaitForSeconds(.5f);
            transform.localEulerAngles+=rotateSword1;
            yield return new WaitForSeconds(.15f);
            swordHit1.SetActive(false);
        }
    }
    IEnumerator SwordTwo()
    {
        if(Input.GetMouseButtonDown(0))
        {
            swordHit2.SetActive(true);
            Debug.Log("Swing");
            yield return new WaitForSeconds(.15f);
            transform.localEulerAngles=rotateSword2;
            transform.localPosition=p2;
            yield return new WaitForSeconds(.5f);
            transform.localEulerAngles=rotator;
            transform.localPosition=p1;
            yield return new WaitForSeconds(.15f);
            swordHit2.SetActive(false);
        }
    }
    IEnumerator BowOne()
    {
        if(Input.GetMouseButtonDown(0))
        {
            BowHit1.SetActive(true);
            Debug.Log("Hit");
            yield return new WaitForSeconds(1);
            BowHit2.SetActive(false);
        }
    }
    IEnumerator BowTwo()
    {
        if(Input.GetMouseButtonDown(0))
        {
            BowHit2.SetActive(true);
            Debug.Log("Hit");
            yield return new WaitForSeconds(1);
            BowHit2.SetActive(false);
        }
    }

    public void WPosition()
    {
        if(temp==0)
        {
            switch(weapon)
            {
                case 1:
                    rotator.Set(50.999f,180,-92.457f);
                    transform.localEulerAngles=rotator;
                    //Debug.Log("Hi");
                    temp++;
                    break;
                case 2:
                    rotator.Set(28.765f,336.836f,78.366f);
                    transform.localEulerAngles=rotator;
                    temp++;
                    break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        WPosition();
        Hit();
        //Shot();
    }
}
