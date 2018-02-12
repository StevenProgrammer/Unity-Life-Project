using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracont : MonoBehaviour {


    public bool Enabled3d = false;
    GameObject camerapos;
    GameObject life3d;
    GameObject life3dRight;
    GameObject life3dBack;


    // Use this for initialization
    void Awake()
    {

        life3d = GameObject.Find("angle");
        life3dRight = GameObject.Find("angle2");
        life3dBack = GameObject.Find("angle3");
        camerapos = GameObject.Find("Main Camera");
    }


    public void ButtonBehaviour3d()
    {
        {
            Enabled3d = true;
            //when 3d is enabled show the other dimentions
            life3d.SetActive(true);
            life3dRight.SetActive(true);
            life3dBack.SetActive(true);
            //while 3d is enabled
            //creating a psudo 3d field
            //the left side
            life3d.transform.position = new Vector3(5.8f, 10.92816f, 9.5f);
            life3d.transform.eulerAngles = new Vector3(0, -165, 0);
            //the right side
            life3dRight.transform.position = new Vector3(-45.09f, 10.92816f, 9.32f);
            life3dRight.transform.eulerAngles = new Vector3(0, -165, 0);
            //the back side
            life3dBack.transform.position = new Vector3(10.3f, 10.92816f, 94.6f);
            life3dBack.transform.eulerAngles = new Vector3(0, -75, 0);
            //allowing the camera to change position when 3d is enabled
            camerapos.transform.position = new Vector3(59.72f, 20.95f, -28.53f);
            camerapos.transform.eulerAngles = new Vector3(-5.43f, -19.156f, 0);
        }

    }

    public void ButtonBehaviour2d()
    {
        Enabled3d = false;
        //when 3d is false hide the extra dimentions
        life3d.SetActive(false);
        life3dRight.SetActive(false);
        life3dBack.SetActive(false);
        //when 3d is false return camera to 2d postion
        camerapos.transform.position = new Vector3(24.06f, 20.95f, -18.84f);
        camerapos.transform.eulerAngles = new Vector3(0, 0, 0);
    }

}
