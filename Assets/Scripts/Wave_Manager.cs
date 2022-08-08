using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Manager : MonoBehaviour
{
    public int wave = 0;
    GameObject money;
    int waveMoney = 10;

    //Bloons
    public GameObject redBloon;

    //Wave1 amounts
    int wave1Red = 5;

    //Wave2 amounts
    int wave2Red = 9;

    //Wave3 amounts
    int wave3Red = 7;
    int wave3Blue = 2;

    //Wave4 amounts
    int wave4Red = 9;
    int wave4Blue = 5;

    //Wave5 amounts
    int wave5Red = 2;
    int wave5Blue = 7;

    //Wave6 amounts
    int wave6Red = 4;
    int wave6Blue = 4;
    int wave6Green = 1;

    //Wave7 amounts
    int wave7Red = 5;
    int wave7Blue = 5;
    int wave7Green = 2;

    //Wave8 amounts
    int wave8Red = 3;
    int wave8Blue = 5;
    int wave8Green = 4;

    //Wave9 amounts
    int wave9Green = 8;

    //Wave10 amounts
    int wave10Blue = 25;

    //Wave11 amounts
    int wave11Red = 3;
    int wave11Blue = 3;
    int wave11Green = 3;
    int wave11Yellow = 1;

    //Wave12 amounts
    int wave12Blue = 4;
    int wave12Green = 3;
    int wave12Yellow = 2;

    //Wave13 amounts
    int wave13Blue = 13;
    int wave13Green = 6;

    //Wave14 amounts
    int wave14Red = 13;
    int wave14Blue = 4;
    int wave14Green = 3;
    int wave14Yellow = 3;

    //Wave15 amounts
    int wave15Red = 5;
    int wave15Blue = 4;
    int wave15Green = 3;
    int wave15Yellow = 3;
    int wave15Pink = 2;

    //Wave16 amounts
    int wave16Green = 10;
    int wave16Yellow = 2;

    //Wave17 amounts
    int wave17YellowRegen = 8;

    //Wave18 amounts
    int wave18Green = 20;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NextWave();
        }
    }

    public void NextWave()
    {
        wave = wave + 1;
        waveMoney += 1;
        money = GameObject.Find("Chash");
        money.GetComponent<Money_Script>().money += waveMoney;
        
        if(wave == 1) 
        {
            Wave1();
        }

        if(wave == 2) 
        {
            Wave2();
        }
        
        if(wave == 3) 
        {
            Wave3();
        }

        if(wave == 4) 
        {
            Wave4();
        }

        if(wave == 5) 
        {
            Wave5();
        }

        if(wave == 6) 
        {
            Wave6();
        }

        if(wave == 7) 
        {
            Wave7();
        }

        if(wave == 8) 
        {
            Wave8();
        }

        if(wave == 9) 
        {
            Wave9();
        }

        if(wave == 10) 
        {
            Wave10();
        }

        if(wave == 11) 
        {
            Wave11();
        }

        if(wave == 12) 
        {
            Wave12();
        }

        if(wave == 13) 
        {
            Wave13();
        }

        if(wave == 14) 
        {
            Wave14();
        }

        if(wave == 15)
        {
            Wave15();
        }

        if(wave == 16)
        {
            Wave16();
        }

        if(wave == 17)
        {
            Wave17();
        }

        if(wave == 18)
        {
            Wave18();
        }
    }

    void Wave1()
    {
        for(int i = 0; i < wave1Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave2()
    {
        for(int i = 0; i < wave2Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave3()
    {
        for(int i = 0; i < wave3Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave3Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave4()
    {
        for(int i = 0; i < wave4Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave4Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave5()
    {
        for(int i = 0; i < wave5Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave5Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }


    void Wave6()
    {
        for(int i = 0; i < wave6Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave6Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave6Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

    
    }

    void Wave7()
    {
        for(int i = 0; i < wave7Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave7Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave7Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }


    void Wave8()
    {
        for(int i = 0; i < wave8Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave8Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave8Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }

    void Wave9()
    {

        for(int i = 0; i < wave9Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave10()
    {

        for(int i = 0; i < wave10Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave11()
    {

        for(int i = 0; i < wave11Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave11Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave11Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave11Yellow; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }

    void Wave12()
    {

        for(int i = 0; i < wave12Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave12Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave12Yellow; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }

    void Wave13()
    {

        for(int i = 0; i < wave13Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave13Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave14()
    {

        for(int i = 0; i < wave14Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave14Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave14Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave14Yellow; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = false;
        }
    }

    void Wave15()
    {

        for(int i = 0; i < wave15Red; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 1;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave15Blue; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 2;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave15Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave15Yellow; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave15Pink; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 5;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }

    void Wave16()
    {

        for(int i = 0; i < wave16Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }

        for(int i = 0; i < wave16Yellow; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = false;
        }

    }

    void Wave17()
    {
        for(int i = 0; i < wave17YellowRegen; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 4;
            enemy.GetComponent<Ballon>().regen = true;
        }


    }

    void Wave18()
    {
        for(int i = 0; i < wave18Green; i++)
        {
            GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
            enemy.GetComponent<Ballon>().startHp = 3;
            enemy.GetComponent<Ballon>().regen = false;
        }
        wave = 0;
    }
}
