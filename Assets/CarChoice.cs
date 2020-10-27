using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace taxi
{
    public class CarChoice : MonoBehaviour
    {


        MainMenu scri;
        Movement carmove1;
        movement2 carmove2;
        public bool test = false;

        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            scri = GameObject.FindObjectOfType<MainMenu>();
             carmove1 = GameObject.FindObjectOfType<Movement>();
            carmove2 = GameObject.FindObjectOfType<movement2>();


            // if (retro)

        }

        // Update is called once per frame
        void Update()
        {
           if (scri.retro)
            {
                //carmove1.enabled = true;
                test = true;
            }
            


        }
    }
}

