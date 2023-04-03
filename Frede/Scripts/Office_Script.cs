using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Office_Script : MonoBehaviour
{
   
    void Start()
    {

        StartCoroutine(officeLoad());

    }


    IEnumerator officeLoad()
    {

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Office");


    }
   
    void Update()
    {
        
    }
}
