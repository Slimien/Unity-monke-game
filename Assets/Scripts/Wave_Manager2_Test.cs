using UnityEngine;

public class Wave_Manager2_Test : MonoBehaviour
{
    public int wavenr = 0;
    GameObject money;
    int waveMoney = 10;
    string wave;

    //Bloons
    public GameObject redBloon;
    int [][] waves = new int [][] {
        //Wave1 amounts
        new int[] {1,5,0,0,0,0},

        //Wave2 amounts
        new int[] {2,9,0,0,0,0},

        //Wave3 amounts
        new int[] {3,7,2,0,0,0},

        //Wave4 amounts
        new int[] {4,9,5,0,0,0},

        //Wave5 amounts
        new int[] {5,2,7,0,0,0},

        //Wave6 amounts
        new int[] {6,4,4,1,0,0},

        //Wave7 amounts
        new int[] {7,5,5,2,0,0},

        //Wave8 amounts
        new int[] {8,3,5,4,0,0},

        //Wave9 amounts
        new int[] {9,0,0,8,0,0},

        //Wave10 amounts
        new int[] {10,0,25,0,0,0},

        //Wave11 amounts
        new int[] {11,3,3,3,1,0},

        //Wave12 amounts
        new int[] {12,0,4,3,2,0},

        //Wave13 amounts
        new int[] {13,0,13,6,0,0},

        //Wave14 amounts
        new int[] {14,13,4,3,3,0},

        //Wave15 amounts
        new int[] {15,5,4,3,3,2},

        //Wave16 amounts
        new int[] {16,0,0,10,2,0},

        //Wave17 amounts
        new int[] {17,0,0,0,0,0},

        //Wave18 amounts
        new int[] {18,0,0,20,0,0},

        //Wave19 amounts 
        new int[] {19,0,0,0,0,0}

    };

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
        wavenr += 1;
        waveMoney += 1;
        money = GameObject.Find("Chash");
        money.GetComponent<Money_Script>().money += waveMoney;
        
        foreach (int[] wave in waves)
        {
            if(wave[0] == wavenr){
                for(int i = 0; i < wave[1]; i++)//red
                {
                    GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
                    enemy.GetComponent<Ballon>().startHp = 1;
                    enemy.GetComponent<Ballon>().regen = false;
                }
                for(int i = 0; i < wave[2]; i++)//blue
                {
                    GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
                    enemy.GetComponent<Ballon>().startHp = 2;
                    enemy.GetComponent<Ballon>().regen = false;
                }
                for(int i = 0; i < wave[3]; i++)//Green
                {
                    GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
                    enemy.GetComponent<Ballon>().startHp = 3;
                    enemy.GetComponent<Ballon>().regen = false;
                }
                for(int i = 0; i < wave[4]; i++)//yellow
                {
                    GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
                    enemy.GetComponent<Ballon>().startHp = 4;
                    enemy.GetComponent<Ballon>().regen = false;
                }
                for(int i = 0; i < wave[5]; i++)//pink
                {
                    GameObject enemy = Instantiate(redBloon, new Vector2(5, Random.Range(5, -5)), transform.rotation);
                    enemy.GetComponent<Ballon>().startHp = 5;
                    enemy.GetComponent<Ballon>().regen = false;
                }
                break;
            }
        }
    }
}
