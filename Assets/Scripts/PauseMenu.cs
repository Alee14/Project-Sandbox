using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool lockCursor = true;

    public GameObject panel;
    private int counter;
    // Update is called once per frame
    public void showhidePanel()
    {
        counter++;
        if (counter % 2 == 1)
        {
            panel.gameObject.SetActive(true);
        }
        else
        {
            panel.gameObject.SetActive(false);
        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockCursor = !lockCursor;
            showhidePanel();
            
        }

        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}
