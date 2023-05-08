using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public Button restartButton;
    public Button mainMenuButton;
    public GameObject MainMenuUI;
    public GameObject gameOverUI;

    public static bool GameIsOver=GameOverScreen.GameIsOver;
    public GameObject Shop;
    void Start()
    {
        Button restart = restartButton.GetComponent<Button>();
        Button mainMenu = mainMenuButton.GetComponent<Button>();
        
        restart.onClick.AddListener(RestartGame);
        mainMenu.onClick.AddListener(OpenMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMainMenu()
    {
        GameIsOver=false;
        Shop.SetActive(false);
        gameOverUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
    public void RestartGame()
    {
        GameIsOver=false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("RESTART BUTTON WORKING");
    }
}
