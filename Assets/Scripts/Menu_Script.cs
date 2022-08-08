using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{

    public GameObject optionsMenu;
    public GameObject mainMenu;
    public GameObject gameModeMenu;


    void Start()
    {
        MainMenu();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
        gameModeMenu.SetActive(false);
    }

    public void GameModes()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(false);
        gameModeMenu.SetActive(true);
    }

    public void MainMenu()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        gameModeMenu.SetActive(false);
    }

    public void StartSurival()
    {
        SceneManager.LoadScene("Game");
    }
}
