using System;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public class Weapon
    {
        public float fireRate;
        public int damage;
        public bool lead;
        public float splashRange;
        public int pierce;

        public Weapon(float weaponFireRate, int weaponDamage, bool weaponLead, float weapoSplashrange, int weaponPierce)
        {
            fireRate = weaponFireRate;
            damage = weaponDamage;
            lead =weaponLead;
            splashRange = weapoSplashrange;
            pierce = weaponPierce;

        }
    }

    float timeSinceAttack;


    Weapon standardDart = new Weapon(1.5f, 1, false, 0.1f, 1);
    Weapon dartlingGunner = new Weapon(0.1f, 1, false, 0.1f, 1);
    Weapon handheldBombTower = new Weapon(2, 3, true, 1.5f, 1);
    public Weapon curentWeapon = new Weapon(1.5f, 1, false, 0.1f, 1);

    public GameObject dartPrefab;
    public Transform firePoint;

    public GameObject chash;
    int leftUppgrade = 0;
    public int leftUppgradePrice = 50;
    int middleUppgrade = 0;
    public int middleUppgradePrice = 80;
    int rightUppgrade = 0;
    public int rightUppgradePrice = 70;

    void Update()
    {
        //make time since attack bigger
        timeSinceAttack += Time.deltaTime;

        //Attack input
        if(Input.GetKey(KeyCode.Mouse0))
        {   
            //checks cooldown
            if(curentWeapon.fireRate <= timeSinceAttack)
            {
                //instantiate Bullet
                GameObject dart = Instantiate(dartPrefab, transform.position, transform.rotation) as GameObject;

                //reset cooldown
                timeSinceAttack = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            curentWeapon = new Weapon(1.5f, 1, false, 0.1f, 1);
        } else if(Input.GetKeyDown(KeyCode.P))
        {
            curentWeapon = new Weapon(0.0f, 10, false, 3, 999);
        }
    }

    public void LeftUppgrade()
    {

        if(chash.GetComponent<Money_Script>().money >= leftUppgradePrice)
        {
            chash.GetComponent<Money_Script>().money -=leftUppgradePrice;

            if(leftUppgrade == 0)
            {
                curentWeapon.fireRate = curentWeapon.fireRate * 0.8f;
                leftUppgradePrice = 100;
                
            }else if(leftUppgrade == 1){
                curentWeapon.fireRate = curentWeapon.fireRate * 0.8f;
                leftUppgradePrice = 175;
            
            }else if(leftUppgrade == 2){
                curentWeapon.fireRate = curentWeapon.fireRate * 0.5f;
                leftUppgradePrice = 200;   

            }else if(leftUppgrade == 3){
                curentWeapon.fireRate = curentWeapon.fireRate * 0.6f;
            
            }else
            {
                return;
            }
            leftUppgrade += 1;
        }       
    }

    public void MiddleUppgrade()
    {

        if(chash.GetComponent<Money_Script>().money >= middleUppgradePrice)
        {
            chash.GetComponent<Money_Script>().money -=middleUppgradePrice;
            
            if(middleUppgrade == 0)
            {
                curentWeapon.damage += 1;
                middleUppgradePrice = 100;
                
            }else if(middleUppgrade == 1){
                curentWeapon.damage += 1;
                middleUppgradePrice = 200;
            
            }else if(middleUppgrade == 2){
                curentWeapon.damage += 1;
                curentWeapon.lead = true;  
                middleUppgradePrice = 300;    
            }else if(middleUppgrade == 3)
            {
                curentWeapon.damage += 2;
            }
            else
            {
                return;
            }

            middleUppgrade += 1;
        }       
    }

    public void RightUppgrade()
    {

        if(chash.GetComponent<Money_Script>().money >= rightUppgradePrice)
        {
            chash.GetComponent<Money_Script>().money -=rightUppgradePrice;
            
            if(rightUppgrade == 0)
            {
                curentWeapon.pierce += 1;
                rightUppgradePrice = 60;
                
            }else if(rightUppgrade == 1){
                curentWeapon.fireRate = curentWeapon.fireRate * 0.9f;
                rightUppgradePrice = 110;
            
            }else if(rightUppgrade == 2){
                curentWeapon.damage += 1;

                rightUppgradePrice = 200;  
                  
            }else if(rightUppgrade == 3)
            {
                curentWeapon.pierce += 1;
                curentWeapon.splashRange += 0.5f;
            }
            else
            {
                return;
            }

            rightUppgrade += 1;
        }       
    }

    public void DartlingGunner()
    {
        if(chash.GetComponent<Money_Script>().money >= 350)
        {
            curentWeapon = dartlingGunner;
            middleUppgrade = 0;
            leftUppgrade = 0;
            rightUppgrade = 0;
            chash.GetComponent<Money_Script>().money -= 350;
            leftUppgradePrice = 50;
            middleUppgradePrice = 80;
            rightUppgradePrice = 70;
            
        }
    }

    public void BombTower()
    {
        if(chash.GetComponent<Money_Script>().money >= 400)
        {
            curentWeapon = handheldBombTower;
            middleUppgrade = 0;
            leftUppgrade = 0;
            rightUppgrade = 0;
            chash.GetComponent<Money_Script>().money -= 400;
            leftUppgradePrice = 50;
            middleUppgradePrice = 80;
            rightUppgradePrice = 70;
            
        }
    }

}
