using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart_Script : MonoBehaviour
{
    [SerializeField] GameObject self;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int speed;
    int durability;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Monke");
        durability = player.GetComponent<Combat>().curentWeapon.pierce;
    }

    void Update()
    {   
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player") 
        {
            durability -= 1;
        }
        if( durability <= 0)
        {
            Destroy(self);
        }
    }

}
