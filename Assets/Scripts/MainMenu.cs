using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
	public Button startButton;
	public Button quitButton;
	public GameObject Shop;
    public void Start()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
		Shop.SetActive(true);
        Debug.Log("Start BUTTON WORKING");
    }
}
