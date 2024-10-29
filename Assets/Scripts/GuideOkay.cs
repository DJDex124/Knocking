using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideOkay : MonoBehaviour
{ 

    public void Okay()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);


    }






}
