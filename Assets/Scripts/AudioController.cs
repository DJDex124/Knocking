using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    public AudioSource planks, walking, door;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPlankPickup()
    {
        planks.Stop();  
        planks.Play();  

    }


    public void PlayDoorOpen()
    {
        door.Stop();
        door.Play();


    }


    public void PlayFootstepWalking()
    {

        walking.Stop();
        walking.Play();

    }



}
