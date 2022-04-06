using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public GameObject BloodScreen;
    public Text healthText;
    public int health;

   
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <=  0)
        {
            SceneManager.LoadScene ("GameOver");
        }
        
    }
     public void zombieAttack (bool zombieIsThere)
     {
       BloodScreen.gameObject.SetActive (true);
       StartCoroutine (wait2seconds());
       health -= 2;
       string stringHealth =  (health).ToString ();
       healthText.text = "" +stringHealth;
        
     }
      IEnumerator wait2seconds()
    {
       yield return new WaitForSeconds (2f);
       BloodScreen.gameObject.SetActive (false);
    }

     
}
