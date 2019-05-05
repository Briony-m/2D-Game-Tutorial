using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public GameObject spawnPoint;
    public float respawnDelay;
    public PlayerMovement Player;
    public Bullet bullet;

    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }

   
    void Update()
    {

    }

    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");  //calls the coroutine function
    }

    public IEnumerator RespawnCoroutine()    //coroutine function
    {
        Player.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);  //puts delay on player's return transform.position
        Player.transform.position = spawnPoint.transform.position;
       // gamePlayer.transform.position = gamePlayer.spawnPoint;
        Player.gameObject.SetActive(true);
    }

   




}
