using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public Button ContinueB;
    public GameObject VictoryUI;
    public GameObject MainMenuUI;
    void Start()
    {
        Button Continue = ContinueB.GetComponent<Button>();
        
        Continue.onClick.AddListener(OpenMainMenu);
    }
    public void OpenMainMenu()
    {
        VictoryUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
}
