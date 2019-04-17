using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public GameObject spawnPoint;
    public float respawnDelay;
    public PlayerMovement Player;

    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }

   
    void Update()
    {

    }

    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");
    }

    public IEnumerator RespawnCoroutine()
    {
        Player.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        Player.transform.position = spawnPoint.transform.position;
       // gamePlayer.transform.position = gamePlayer.spawnPoint;
        Player.gameObject.SetActive(true);
    }
}
