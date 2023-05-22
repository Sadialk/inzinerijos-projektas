using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotkey : MonoBehaviour
{
    public GameObject hotkeyUI;
    // Start is called before the first frame update
    void Start()
    {
        hotkeyUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            hotkeyUI.SetActive(false);
        }
    }
}
 