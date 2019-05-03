using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameManager GM;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true)
        {
            if (col.CompareTag("Player"))
            {
                print("Dead");
                col.GetComponent<PlayerMovement>().GM.Respawn();
                Destroy(gameObject);
            }

               
            
        }



    }





}
