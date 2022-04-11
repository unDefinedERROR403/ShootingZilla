using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float health = 30f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void TakeDamage(float damage)
	{
		health -= damage;
		print(health);

		if (health <= 0f)
		{
			Die();
		}
	}

	void Die()
	{
		Destroy(gameObject, 1f);
	}
}
