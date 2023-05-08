using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public Button ContinueB;
    public Button MainMenuB;
    public GameObject VictoryUI;
    void Start()
    {
        Button Continue = ContinueB.GetComponent<Button>();
        Button Main = MainMenuB.GetComponent<Button>();
        
        Main.onClick.AddListener(OpenMainMenu);
        Continue.onClick.AddListener(OpenNextLevel);
    }
    public void OpenNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");

    }
}
