using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAttack : MonoBehaviour
{
    public AudioSource Hurt;
	
	void Start(){
		Hurt = GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals("Hazard"))
		
		{
		Hurt.Play();
		GameControlScript.health -=1;
		}

	}
}
