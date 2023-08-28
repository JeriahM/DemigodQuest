using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Please : MonoBehaviour
{
    public static int g, c;
    void Update()
    {
        Hope();
    }
    void Hope()
    {
        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("SelectionScene"))
        {
            g=UserChoice.story;
            c=UserChoice.character;
        }
    }
}
