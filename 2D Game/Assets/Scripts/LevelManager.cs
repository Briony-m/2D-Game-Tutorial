using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string loadLevel;
    public PlayerMovement Player;
    public GameObject hasKey;
    

 
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (Player.hasKey)
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
