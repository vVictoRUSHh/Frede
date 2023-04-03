using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Scrpt : MonoBehaviour
{
    public Camera Office;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;


    public GameObject CameraUp;
    public GameObject CameraDown;
    void Start()
    {
        Office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);

        CameraUp.SetActive(true) ;
        CameraDown.SetActive(false) ;
       

    }

    void Update()
    {
        
    }



    public void CamUp()
    {



        Office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);

        CameraUp.SetActive(false);
        CameraDown.SetActive(true);


    }
    public void CamDown()
    {



        Office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);


        CameraUp.SetActive(true);
        CameraDown.SetActive(false);


    }

    public void Cam1()
    {
        Office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);

    }
    public void Cam2()
    {
        Office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        cam3.gameObject.SetActive(false);

    }

    public void Cam3()
    {
        Office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(true);

    }
}
