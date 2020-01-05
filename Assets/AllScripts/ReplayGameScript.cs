using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayGameScript : MonoBehaviour
{
    public void RetryLevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	
	public void MenuScreen()
	{
		SceneManager.LoadScene("Main Menu");
	}
}
