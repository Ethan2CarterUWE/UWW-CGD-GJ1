using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    MainMenu menu;

    public bool RetroMovement = false;
    public bool ModernMovement = false;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        menu = GameObject.FindObjectOfType<MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {

        if (menu.retro)
        {
            RetroMovement = true;
        }
        if (menu.modern)
        {
            ModernMovement = true;
        }

        
    }
}
