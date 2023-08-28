using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    Vector3 r;
    void Camera()
    {
        r=transform.localEulerAngles;
        if(transform.localEulerAngles.x>50&&91>transform.localEulerAngles.x)
        {
            r.x=50;
            transform.localEulerAngles=r;
        }
        if(transform.localEulerAngles.x>91&&304>transform.localEulerAngles.x)
        {
            r.x=304;
            transform.localEulerAngles=r;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("Prophecy"))
        {
            GetComponent<AudioListener>().enabled=false;
            GetComponent<Camera>().enabled=false;
        }
        else
        {
            GetComponent<AudioListener>().enabled=true;
            GetComponent<Camera>().enabled=true;
        }
        Camera();
    }
}
