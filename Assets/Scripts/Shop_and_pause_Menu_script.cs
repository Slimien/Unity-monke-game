using System;
using System.Security.Cryptography;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_and_pause_Menu_script : MonoBehaviour
{
    
    public GameObject shopMenu;
    public GameObject pauseMenu;
    public GameObject inGameUI;
    bool shopMenuActive = false;
    bool pauseMenuActive = false;
    void Start()
    {
        shopMenu.SetActive(false);
        pauseMenu.SetActive(false);
        inGameUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(shopMenuActive == false)
            {
                Shop();
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(shopMenuActive == true || pauseMenuActive == true)
            {
                Resume();
            }
        }
    }

    public void Shop()
    {
        shopMenu.SetActive(true);
        inGameUI.SetActive(false);
        Time.timeScale = 0;
        shopMenuActive = true;
    }



    public void Resume()
    {
        shopMenu.SetActive(false);
        inGameUI.SetActive(true);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        pauseMenuActive = false;
        shopMenuActive = false;
    }
}
