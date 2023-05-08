using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenuButtons : MonoBehaviour
{
    
    public GameObject pauseMenuUI;
    public static bool GameIsPaused=PauseMenu.GameIsPaused;
    

    public Button resumebutton;
    public Button mainMenuButton;
    public GameObject MainMenuUI;
    public GameObject ShopUI;

    public GameObject currencyUI;
    public GameObject healthUI;
    void Start()
    {
        Button resume = resumebutton.GetComponent<Button>();
        Button mainMenu = mainMenuButton.GetComponent<Button>();
        
        resume.onClick.AddListener(ResumeGame);
        mainMenu.onClick.AddListener(OpenMainMenu);
    }


    public void OpenMainMenu()
    {
        ShopUI.SetActive(false);

        pauseMenuUI.SetActive(false);
        
        MainMenuUI.SetActive(true);
        GameIsPaused =true;
        PauseMenu.GameIsPaused=true;


        currencyUI.SetActive(false);

        healthUI.SetActive(false);
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
