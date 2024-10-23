using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmount = 25;
    public Animator pickup; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        


    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //simple pick up on collsion code as well as variable float update reference
        
        
        if (other.tag == "Player")
        PlayerController.instance.currentPlanks += ammoAmount;
        PlayerController.instance.UpdatePlanksUI();
        pickup.SetBool("onPickup", true);

        AudioController.instance.PlayPlankPickup();

        Destroy(gameObject);

        

    }

}
