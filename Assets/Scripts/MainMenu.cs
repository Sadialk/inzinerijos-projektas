using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
	public Button startButton;
	public Button quitButton;
    public void Start()
    {
		Button quit = quitButton.GetComponent<Button>();
		Button Start = startButton.GetComponent<Button>();
        Start.onClick.AddListener(StartGame);
        quit.onClick.AddListener(QuitGame);
    }
    public void QuitGame() {
        Application.Quit();
		Debug.Log("Game Quit");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelection");
        Debug.Log("Start BUTTON WORKING");
    }
}
