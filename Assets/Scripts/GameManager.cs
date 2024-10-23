using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    LockCursor();   
    }

    // Update is called once per frame
    void Update()
    {
        //simple code to check if cursor is pressed enabling cursor lock
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            UnlockCursor();
        }
        //If escape key pressed unlocks cursors and makes visible
        if (Input.GetMouseButton(0))
        {

            LockCursor();
        }

    }

    //Cursor Lock so Cursor isnt on screen while playing
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 

    }
    //Cursor unlock so cursor is visible while in menu
    private void UnlockCursor()
    { 
    
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    
    
    }

}



