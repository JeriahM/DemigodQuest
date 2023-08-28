using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Controller : Demigod
    {
        Animator anim;
        [SerializeField] private MouseLook m_MouseLook;
        private Camera m_Camera;
        private float m_YRotation;
        private float speeddiv = 300f;
    
        // Start is called before the first frame update
        void Start()
        {
            anim=GetComponent<Animator>();
            m_Camera = Camera.main;
            m_MouseLook.Init(transform , m_Camera.transform);
        }
        private void movement()
        {
            speedU=((Demigod.stats[spd]*2+Demigod.stats[stl]+Demigod.stats[sta])/3)+bonus1;
            SwdU=((Demigod.stats[swd]*1.5f+Demigod.stats[crft]+Demigod.stats[str]+Demigod.stats[IQ]*.3f)/4)+bonus2;
            ArcU=((Demigod.stats[arc]*2.5f+Demigod.stats[crft]*.5f+Demigod.stats[IQ]*.5f)/3)+bonus3;
            float movement = Input.GetAxis("Vertical");
            float movement2 = Input.GetAxis("Horizontal")*(speedU/speeddiv);
            anim.SetFloat("Speed",movement);
            if(movement<0)
            {
                float temp = movement*-1;
                anim.SetFloat("Speed2",temp);
            }
            movement*=(speedU/speeddiv);
            transform.Translate(movement2,0,movement);

            m_MouseLook.LookRotation(transform,m_Camera.transform);
        }
        
        // Update is called once per frame
        void Update()
        {
            movement();
        }
    }
}