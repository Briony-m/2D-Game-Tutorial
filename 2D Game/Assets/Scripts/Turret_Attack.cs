using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Attack : MonoBehaviour
{
    public TurretAI turretAI;
    public bool isLeft = false;

    void Idle()
    {
        turretAI = gameObject.GetComponentInParent<TurretAI>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isLeft)
            {
                turretAI.Attack(false);
            }
            else
            {
                turretAI.Attack(true);
            }
        }
    }











}
