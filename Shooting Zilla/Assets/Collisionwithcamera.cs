using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionwithcamera : MonoBehaviour
{

    public bool zombieIsThere;
    float timer;
    int timerBetweenAttack;
     private GameControllerScript gameController;
     AudioSource attackSound;

    // Start is called before the first frame update
    void Start()
    {
        timerBetweenAttack = 2;

        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameControllerScript> ();
        }

        AudioSource[] audios = GetComponents<AudioSource> ();
        attackSound = audios [0];
        
    }

    // Update is called once per frame
    void Update()
    {
        timer  +=Time.deltaTime;
        // print(timer);

        if (zombieIsThere && timer >= timerBetweenAttack)
        {
            Attack();
        }
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "MainCamera")
        {
            zombieIsThere = true;
           //Debug.Log ("enter");
        }
    }

    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.tag == "MainCamera")
        {
            zombieIsThere = false;
            //Debug.Log ("exit");
        }
    }
    void Attack()
    {
       timer = 0f;
       GetComponent<Animator> ().Play ("attack");
       gameController.zombieAttack (zombieIsThere);
       attackSound.Play();
        
    }
   

    
}
