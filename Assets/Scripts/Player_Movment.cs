using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{

    [SerializeField] int speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject shop;


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        Vector2 movmentDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if(movmentDirection != Vector2.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.forward, movmentDirection), rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Store" && Input.GetKeyDown(KeyCode.E))    
        {
            Time.timeScale = 0;
        }
    }
}
