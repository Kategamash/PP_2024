using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public bool isOpened;

    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isOpened = !isOpened;
            panel.SetActive(isOpened);
        }
    }
}
