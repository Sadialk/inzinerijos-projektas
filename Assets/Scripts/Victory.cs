using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject MainMenuUI;
    public void OpenMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
