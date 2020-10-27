using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

    Transform transfor;
    Rigidbody2D body;
    public GameObject cars;


    //public bool deleteww = false;
    CarChoice Choice;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

   // bool pause = false;
    bool up = true;
    bool down = false;
    bool right = false;
    bool left = false;
    float y;

    public float Speed = 10.0f;

    void Start()
    {
        Choice = GameObject.FindObjectOfType<CarChoice>();

        body = GetComponent<Rigidbody2D>();
        y = transform.rotation.z;

        if (!Choice.RetroMovement)
        {
            this.enabled = false;
        }
        else
        {
            this.enabled = true;
        }
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down


       if (Input.GetKey("escape"))
        {
            Choice.delete = true;
            //Choice.RetroMovement = false;

            SceneManager.LoadScene("Menu");

        }


        Rotat();
        CarRotate();
       

    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }

    void CarRotate()
    {
        if (body.velocity == new Vector2(0, 0))
        {
            body.angularVelocity = 0;
        }
      
        
        if (right && up)
        {
            cars.transform.eulerAngles = new Vector3(0, 0, 135);
            Debug.Log("up right");

        }
        else if (left && up)
        {
            cars.transform.eulerAngles = new Vector3(0, 0, 45);
            Debug.Log("up left");

        }
        else if (right && down)
        {
            cars.transform.eulerAngles = new Vector3(0, 0, 225);
        }
        else if (left && down)
        {
            cars.transform.eulerAngles = new Vector3(0, 0, 315);
        }
        else if (right)
        { 
                cars.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (up)
        {
                cars.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (down)
        {
                cars.transform.eulerAngles = new Vector3(0, 0, 180);

        }
       else if (left)
        {
            cars.transform.eulerAngles = new Vector3(0, 0, -90);
        }
     
    }

    void Rotat()
    {


        if (vertical == 1)
        {
            up = true;
        }
        else
        {
            up = false;
        }

        if (vertical == -1)
        {
            down = true;
        }
        else
        {
            down = false;
        }

        if (horizontal == 1)
        {
            right = true;

        }
        else
        {
            right = false;
        }

        if (horizontal == -1)
        {
            left = true;
        }
        else
        {
            left = false;
        }
    }



}
