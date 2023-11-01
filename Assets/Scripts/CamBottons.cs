using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBottons : MonoBehaviour
{

    public GameObject camFace;
    public GameObject camLeft;
    public GameObject camDown;
    public GameObject camUp;

    public GameObject camFace2;
    public GameObject camLeft2;
    public GameObject camDown2;
    public GameObject camUp2;

    public GameObject camFace3;
    public GameObject camLeft3;
    public GameObject camDown3;
    public GameObject camUp3;


    public void Up()
    {
        CameraUp();
       
    }

    public void Down()
    {
        CameraDown();
       
    }

    public void Face()
    {
        CameraFace();
       
    }

    public void Left()
    {
       CameraLeft();
       
    }

   public void CameraFace()
    {
        camFace.SetActive(true);
        camFace2.SetActive(true);
        camFace3.SetActive(true);
        camLeft.SetActive(false);
        camLeft2.SetActive(false);
        camLeft3.SetActive(false);
        camDown.SetActive(false);
        camDown2.SetActive(false);
        camDown3.SetActive(false);
        camUp.SetActive(false);
        camUp2.SetActive(false);
        camUp3.SetActive(false);
    }

    public void CameraLeft()
    {
        camFace.SetActive(false);
        camFace2.SetActive(false);
        camFace3.SetActive(false);
        camLeft.SetActive(true);
        camLeft2.SetActive(true);
        camLeft3.SetActive(true);
        camDown.SetActive(false);
        camDown2.SetActive(false);
        camDown3.SetActive(false);
        camUp.SetActive(false);
        camUp2.SetActive(false);
        camUp3.SetActive(false);
    }

    public void CameraDown()
    {
        camFace.SetActive(false);
        camFace2.SetActive(false);
        camFace3.SetActive(false);
        camLeft.SetActive(false);
        camLeft2.SetActive(false);
        camLeft3.SetActive(false);
        camDown.SetActive(true);
        camDown2.SetActive(true);
        camDown3.SetActive(true);
        camUp.SetActive(false);
        camUp2.SetActive(false);
        camUp3.SetActive(false);
    }
    public void CameraUp()
    {
        camFace.SetActive(false);
        camFace2.SetActive(false);
        camFace3.SetActive(false);
        camLeft.SetActive(false);
        camLeft2.SetActive(false);
        camLeft3.SetActive(false);
        camDown.SetActive(false);
        camDown2.SetActive(false);
        camDown3.SetActive(false);
        camUp.SetActive(true);
        camUp2.SetActive(true);
        camUp3.SetActive(true);
    }
    
}

