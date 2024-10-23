using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;

    public Rigidbody2D TheRB;

    public Vector2 moveInput;
    public Vector2 mouseInput;

    public float mouseSensitivity = 1f;


    public float moveSpeed = 5f;

    public Camera viewCam;

    public GameObject BulletImpact;
    public int currentPlanks;

    public Animator handAnim;
    public Animator anim;

    public bool enough;


    public TextMeshProUGUI planks;

    public GameObject winscreen;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        planks.text = currentPlanks.ToString();
        winscreen.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
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



            if (moveInput != Vector2.zero)
            {

                anim.SetBool("IsMoving", true);
                
            }
            else
            {

                anim.SetBool("IsMoving", false);
                AudioController.instance.PlayFootstepWalking();
            }


            
        
            



        }

        
     }










    public class PlayMyAnimation : MonoBehaviour
    {
        [SerializeField] public Animator MyAnimationController;
        // Door Function
        public void OnTriggerEnter2D(UnityEngine.Collider other)
        {
            if (other.CompareTag("Player"))
            {



            }


        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FinalDoor")
        {

            if (currentPlanks == 5f)
            {


                winscreen.SetActive(true);
 

            }








        }
   
    
    
    
    
    
    }




     public void UpdatePlanksUI()
    {
        planks.text = currentPlanks.ToString();

    }




}



