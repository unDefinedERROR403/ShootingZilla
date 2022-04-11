using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadNewGame : MonoBehaviour
{

      public Button  newGame;
    // Start is called before the first frame update
    void Start()
    {
        newGame.onClick.AddListener(loadGame);
        
    }

    // Load is called once per frame
    void loadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
