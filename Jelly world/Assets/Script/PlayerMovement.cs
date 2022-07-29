using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D player;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool isJump = false;
    public Animator playerANI;
    //bool isCrouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        playerANI.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            isJump = true;
            playerANI.SetBool("isJumping", true);
        }

        /*if(Input.GetButtonDown("Crouch"))
        {
            isCrouch = true;
        } else if(Input.GetButtonUp("Crouch"))
        {
            isCrouch = false;
        } */
    }

    public void onLanding()
    {
        playerANI.SetBool("isJumping", false);
    }

    private void FixedUpdate()
    {
        player.Move(horizontalMove * Time.fixedDeltaTime, false, isJump);
        isJump = false;
        
    }
}
