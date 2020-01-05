using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
	public int health = 18;
	
	public void TakeDamage(int damage)
	{
		health -= damage;	
		
		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Debug.Log("Enemy is Dead");
		Destroy(gameObject);
		
		
	}
}