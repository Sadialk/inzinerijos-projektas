using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
}
