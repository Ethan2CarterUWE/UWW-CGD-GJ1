using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	public Transform player;
    public Camera cam;
    public float screenWidth;
    public float screenHeight;
    public Vector3 TRscreenBounds;
    public Vector3 BLscreenBounds;
    // Use this for initialization
    void Start()
	{
       
        screenWidth = cam.orthographicSize *2;
    }



	// Update is called once per frame
	void Update()
	{
        //calculates Top right corner of screen
        TRscreenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 5));
        //calculates bottom left corner of screen
        BLscreenBounds = cam.ScreenToWorldPoint(new Vector3(0, 0, 5));

        if (player.transform.position.x > TRscreenBounds.x )
        {
            cam.transform.position = new Vector3(cam.transform.position.x + 2*(TRscreenBounds.x - cam.transform.position.x), cam.transform.position.y, cam.transform.position.z);
        }
        else if (player.transform.position.x < BLscreenBounds.x )
        {
            cam.transform.position = new Vector3(cam.transform.position.x - 2*(cam.transform.position.x - BLscreenBounds.x), cam.transform.position.y, cam.transform.position.z);
        }
        
        if(player.transform.position.y > TRscreenBounds.y)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 2 * (TRscreenBounds.y - cam.transform.position.y), cam.transform.position.z);
        }
        else if(player.transform.position.y < BLscreenBounds.y)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 2 * (cam.transform.position.y - BLscreenBounds.y), cam.transform.position.z);
        }

    }
}
