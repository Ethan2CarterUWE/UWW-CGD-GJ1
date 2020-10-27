using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace taxi
{
    public class dontdestroy : MonoBehaviour
    {

        CarChoice choice;
        Movement move;

        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            choice = GameObject.FindObjectOfType<CarChoice>();
            move = GameObject.FindObjectOfType<Movement>();



        }

        // Update is called once per frame
        void Update()
        {
            if (choice.test)
            {
                move.enabled = true;
            }
        }
    }
}

