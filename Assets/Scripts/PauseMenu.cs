using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool lockCursor = true;

    public GameObject panel;
    private int m_counter;
    // Update is called once per frame
    public void ShowhidePanel()
    {
        m_counter++;
        if (m_counter % 2 == 1)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            panel.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockCursor = !lockCursor;
            ShowhidePanel();
            
        }

        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}
