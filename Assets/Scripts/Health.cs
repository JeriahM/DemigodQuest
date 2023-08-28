using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : Demigod
{
    float maxH;
    public Text hNum;
    public Slider hBar;
    private void Start()
    {
        userH=100+stats[heal];
        maxH=userH;
    }
    void HealthBar()
    {
        hBar.maxValue=maxH;
        hBar.value=userH;
        userH=(int)userH;
        hNum.text=userH.ToString();
        if(userH==0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
    void CHBHealth()
    {
        userH=100+stats[heal];
        hBar.maxValue=userH;
        hNum.text=userH.ToString();
        hBar.value=userH;
        maxH=userH;

    }
    void Game()
    {
        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Camp Half Blood"))
        {
            CHBHealth();
        }
        else
        {
            HealthBar();
        }
    }
    void Update()
    {
        Game();
    }
}
