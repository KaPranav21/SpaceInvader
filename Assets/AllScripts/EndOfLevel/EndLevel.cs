﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D col)
		{
			if (col.gameObject.tag.Equals("Player1"))
			{
				
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}
}
