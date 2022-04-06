using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionWithCamra : MonoBehaviour
{

	public bool zombieIsThere;
	float timer;
	int timeBetweenAttack;
	public GameObject BloodScreen;
	private GameControllerScript gameController;

	// Use this for initialization
	void Start()
	{
		timeBetweenAttack = 2;

		GameObject gameControllerObject = GameObject.FindWithTag("GameController");

		if (gameControllerObject != null)
        {
			gameController = gameControllerObject.GetComponent<GameControllerScript>();

		}
	}

	// Update is called once per frame
	void Update()
	{

		timer += Time.deltaTime;

		if (zombieIsThere && timer >= timeBetweenAttack)
		{
			Attack();
		}

	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "MainCamera")
		{
			zombieIsThere = true;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "MainCamera")
		{
			zombieIsThere = false;
		}
	}

	void Attack()
	{
		timer = 0f;
		GetComponent<Animator>().Play("attack");
		gameController.zombieAttack(zombieIsThere);
		BloodScreen.gameObject.SetActive(true);
		StartCoroutine(wait2seconds());  
	}

	IEnumerator wait2seconds()
    {
		yield return new WaitForSeconds(2f);
		BloodScreen.gameObject.SetActive(false);
	}
}
