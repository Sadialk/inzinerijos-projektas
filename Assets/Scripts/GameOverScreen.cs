using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;
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
    }
}
