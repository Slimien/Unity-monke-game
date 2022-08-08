using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{

    GameObject player;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Monke");

        //Move towards player
        rb.velocity = (player.transform.position - transform.position).normalized;

        //move at given speed
        rb.velocity = rb.velocity * new Vector3(speed, speed, 0);


        

    }
}
