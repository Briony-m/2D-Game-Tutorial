using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameManager GM; //reference to GameManager script
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true)
        {
            if (col.CompareTag("Player"))
            {
                print("Dead");
                col.GetComponent<PlayerMovement>().GM.Respawn();   //starts respawn coroutine in game manager script
                Destroy(gameObject); //destroys bullet when it collides with 'Player'
            }
            if (col.CompareTag("Colliders"))
            {
                //this stops bullets from being destroyed as soon as they hit trigger for the turret range
                Destroy(gameObject);
            }  


        }



    }





}
