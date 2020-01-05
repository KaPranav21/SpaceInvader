using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartReGen : MonoBehaviour
{
	private AudioSource Regen;
	Vector2 tempPos;
	
	void Start() {
		Regen = GetComponent<AudioSource>();
	}

	
	void OnTriggerEnter2D(Collider2D col)
	{
		
		
		if (col.gameObject.tag.Equals("Player1"))		
		{
		
		tempPos = transform.position;
		tempPos.x += 999;
		transform.position = tempPos;

		Regen.Play();		
		GameControlScript.health += 1;
		
		}
	
	}
	
}
