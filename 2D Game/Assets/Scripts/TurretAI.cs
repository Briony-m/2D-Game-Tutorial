using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{

    //Floats
    public float distance;
    public float idleRange;
    public float shootInterval;
    public float bulletSpeed = 100;
    public float bulletTimer;

    //boolians
    public bool idle = false;
    public bool lookingRight = true;

    //References
    public GameObject bullet;
    public Transform target;
    public Animator anim;
    public Transform shootPointLeft, shootPointRight;

    void Idle()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Start()
    {
        

    }

    void Update()
    {
        anim.SetBool("Idle", idle);
        anim.SetBool("LookingRight", lookingRight);

        if (target.transform.position.x > transform.position.x)
        {
            lookingRight = false;
        }
        if (target.transform.position.x < transform.position.x)
        {
            lookingRight = true;
        }

    }

    void RangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < idleRange)
        {
            idle = true;
        }
        if(distance > idleRange)
        {
            idle = false;
        }
    }


    public void Attack(bool AttackingRight)
    {
        bulletTimer += Time.deltaTime;

        if (bulletTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (AttackingRight)
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                bulletTimer = 0;
            }
            if (!AttackingRight)
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointRight.transform.position, shootPointRight.transform.rotation);
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                bulletTimer = 0;
            }

        }



    }





}
