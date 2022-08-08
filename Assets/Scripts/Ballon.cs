using System.Threading;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballon : MonoBehaviour
{

    public int startHp;
    public int hp;
    GameObject player;
    int poppingPower;
    [SerializeField] GameObject self;
    [SerializeField] SpriteRenderer renderer;
    public GameObject moneyCounter;
    public LayerMask enemyLayers;
    public bool regen;
    float regenTimer;

    void Start()
    {
        player = GameObject.Find("Monke");

        moneyCounter = GameObject.Find("Chash");
        hp = startHp;
    }

    void Update()
    {
        poppingPower = player.GetComponent<Combat>().curentWeapon.damage;

        if(regen && hp < startHp)
        {
            regenTimer += Time.deltaTime;

            if(regenTimer >= 5)
            {
                regenTimer = 0;
                hp += 1;
                
            }
        }

        if(hp == 1)
        {
            renderer.color = new Color(255f, 0f, 0f, 255f);
        }

        if(hp == 2)
        {
            renderer.color = new Color(0f, 150f, 255f, 255f);
        }

        if(hp == 3)
        {
            renderer.color = new Color(0f, 255f, 0f, 255f);
        }

        if(hp == 4)
        {
            renderer.color = new Color(50f, 255f, 0f, 255f);
        }

        if(hp == 5)
        {
            renderer.color = new Color(255f, 0f, 190f, 255f);
        }
    }
    


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == player)
        {
            SceneManager.LoadScene("Menu");
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
           if(collision.gameObject.tag == "Projectile")
        {
            takeDamage(poppingPower);
        }

    }


    void takeDamage(int damage)
    {
        if(player.GetComponent<Combat>().curentWeapon.splashRange > 0.1f)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, player.GetComponent<Combat>().curentWeapon.splashRange, enemyLayers);

                //damages enemies in attackrange
                foreach (Collider2D Enemies in hitEnemies)
                {
                    Enemies.GetComponent<Ballon>().takeDamageNoSplash(poppingPower / 2);  
                }
        }

        hp -= damage;
        moneyCounter.GetComponent<Money_Script>().money += player.GetComponent<Combat>().curentWeapon.damage;

        if(hp < 0)
        {
            moneyCounter.GetComponent<Money_Script>().money += hp;
            Poped();
        }else if(hp == 0)
        {
            Poped();
        }
    }

    void takeDamageNoSplash(int damage)
    {
        hp -= damage;
        moneyCounter.GetComponent<Money_Script>().money += player.GetComponent<Combat>().curentWeapon.damage;
        
        if(hp < 0)
        {
            moneyCounter.GetComponent<Money_Script>().money += hp;
            Poped();
        }else if(hp == 0)
        {
            Poped();
        }
    }

    void Poped()
    {
        Destroy(self);
    }

}
