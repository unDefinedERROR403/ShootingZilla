using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootEnemy : MonoBehaviour
{
	public Button shootBtn;
	public Camera fpsCam;
	public float damage = 10f;
	public int score;
	public Text scoreText;


	// Use this for initialization
	void Start()
	{

		shootBtn.onClick.AddListener(onShoot);

	}
	           

	void onShoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
		{

			Enemy target = hit.transform.GetComponent<Enemy>();
			

			if (target != null)
			{
				target.TakeDamage(damage);
				score = score + 1;
				string scorestring = (score).ToString ();
			    scoreText.text = "/" + scorestring;
			}

			// destroy enemy
			// instantiate blood effect
			// load shooting effect 
			//Debug.Log (hit.transform.name);
		}
	}
}
