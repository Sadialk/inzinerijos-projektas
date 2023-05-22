using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Button MainMenuB;
    // Start is called before the first frame update
    void Start()
    {
        Button Main = MainMenuB.GetComponent<Button>();
        Main.onClick.AddListener(OpenMainMenu);
    }

    void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
        
    }
}
