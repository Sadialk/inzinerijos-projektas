using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;
public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;
    void Start() {
        
    }
    void Update() {
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        Debug.Log("A");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
