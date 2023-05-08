using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    void Start()
    {
        Button lvl1 = Button1.GetComponent<Button>();
        Button lvl2 = Button2.GetComponent<Button>();
        Button lvl3 = Button3.GetComponent<Button>();
        Button lvl4 = Button4.GetComponent<Button>();
        
        Button1.onClick.AddListener(Load1);
        Button2.onClick.AddListener(Load2);
        Button3.onClick.AddListener(Load3);
        Button4.onClick.AddListener(Load4);
    }
    public void Load1() {
        SceneManager.LoadScene("SampleScene");
    }
    public void Load2() {
        SceneManager.LoadScene("Level2");
    }
    public void Load3() {
        SceneManager.LoadScene("Level3");
    }
    public void Load4() {
        SceneManager.LoadScene("Level4");
    }
}
