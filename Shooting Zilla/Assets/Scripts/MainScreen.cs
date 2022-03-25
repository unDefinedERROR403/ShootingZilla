using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fight()
    {
        SceneManager.LoadScene("UnityARKitScene");
    }
    public void GSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void back()
    {
        SceneManager.LoadScene("NexScene");
    }
    public void shop()
    {
        SceneManager.LoadScene("FocusCircle");
    }
    
}
