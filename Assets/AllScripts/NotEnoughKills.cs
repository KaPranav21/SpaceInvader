﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotEnoughKills : MonoBehaviour
{
void start(){
	
}


    void OnTriggerEnter2D (Collider2D col)
	{
		
		if (col.gameObject.tag.Equals ("KillThem"))
		{
			Destroy(gameObject);
		}
			
		}
	}
