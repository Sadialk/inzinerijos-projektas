using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;

    public GameObject shopUI;
    public GameObject currencyUI;
    public GameObject healthUI;
    public static bool GameIsOver=false;
    void Start() {
        
    }
    void Update() {
        
    }
    public void gameOver()
    {
        GameIsOver=true;
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        shopUI.SetActive(false);
        currencyUI.SetActive(false);
        healthUI.SetActive(false);
    }
}
