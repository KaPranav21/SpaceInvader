using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
	{
		
		if (col.gameObject.tag.Equals ("Player1"))
		{
			//Debug.Log("-1 heart");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
			
	}
}
