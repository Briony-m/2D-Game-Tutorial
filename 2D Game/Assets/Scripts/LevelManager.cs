using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string loadLevel; 
    public PlayerMovement Player; //reference to other script
    public GameObject hasKey;     //reference to other script



    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (Player.hasKey)// if player has the 'pickup' player can then go through door which will load next scene
            {
                SceneManager.LoadScene(loadLevel);

            }
            
            // bool hasKey = true;
            //When player collides with door check if bool is true, then 
           
           

        }
       // else
      //  {
           // hasKey = false; //if they dont got the key they cant open the door
      //  }
    }


    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }




}
