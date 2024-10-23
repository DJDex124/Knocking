using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Deposit : MonoBehaviour
{

    public GameObject endScreen;
    public bool isEnd;




    // Start is called before the first frame update
    void Start()
    {
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void QuitGame()
    {
        Application.Quit();


    }

    public void EndGame()
    {

        endScreen.SetActive(true);
        isEnd = false;

    }

    public void NotEndGame()
    {

        endScreen.SetActive(false);
        isEnd = true;


    }

}
