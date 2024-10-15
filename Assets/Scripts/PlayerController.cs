using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;
using UnityEngine.UI;
using TMPro;
using System;


public class PlayerController : MonoBehaviour
{

    public static PlayerController instance; 

    public Rigidbody2D TheRB;

    private Vector2 moveInput;
    private Vector2 mouseInput;

    public float mouseSensitivity = 3f;


    public float moveSpeed = 5f;

    public Camera viewCam;

    public GameObject BulletImpact;

    public int currentPlanks;

    public Animator gunAnim;
    public Animator anim;

    public Animator pickupAnim;


    public TextMeshProUGUI planks;
  
                


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {   
        planks.text = currentPlanks.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


        Vector3 moveHorizontal = transform.up * -moveInput.x;

        Vector3 moveVertical = transform.right * moveInput.y;

        TheRB.velocity = (moveHorizontal + moveVertical) * moveSpeed;



        //player view control
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - mouseInput.x);


        viewCam.transform.localRotation = Quaternion.Euler(viewCam.transform.localRotation.eulerAngles + new Vector3(0f, mouseInput.y, 0f));


        //Shooting

        if (Input.GetButton("e"))
        {
            if (currentPlanks > 0)
            {
                Ray ray = viewCam.ViewportPointToRay(new Vector3(.5f, .5f, .5f));

                RaycastHit hit;


                
            }

        }


        if (moveInput != Vector2.zero)
        {
            anim.SetBool("IsMoving", true);
        }else
        {
            anim.SetBool("IsMoving", false);
        }

       
    
    
    }


    public class PlayMyAnimation : MonoBehaviour
    {
        [SerializeField] private Animator MyAnimationController;

        private void OnTriggerEnter2D(Collider other)
        {
            if (other.CompareTag("Player")){
                
              

            }


        }


    }
    public void UpdatePlanksUI()
    {
        planks.text = currentPlanks.ToString();

    }
}


