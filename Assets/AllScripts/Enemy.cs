using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int health = 18;

	void Start(){

	}

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
		
		Destroy(gameObject);

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag.Equals("DeathZone"))
		{
			Destroy(gameObject);
		}
	}
}
