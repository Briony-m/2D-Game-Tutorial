using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float speed = 40f;
    bool jump = false;
    bool crouch = false;
    public GameObject Player;
    public GameManager GM;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal")* speed;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("DeathZone"))
        {
            print("Dead");
            
            StartCoroutine(MovePlayer());
         
        }
       
    }
    IEnumerator MovePlayer()
    {
        yield return new WaitForSeconds(0.7f);
        transform.position = GM.spawnPoint.transform.position;
    }


    }



