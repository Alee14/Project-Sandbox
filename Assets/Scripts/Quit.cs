using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame() {
        Debug.Log("Game has closed.");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }       
        
    }
}
