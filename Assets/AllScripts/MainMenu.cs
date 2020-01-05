using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
   
	public void PlayLevel1()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X_1");
   }

	public void PlayLevel2()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X_2");
   }

   public void PlayLevel3()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X_3");
   }

   public void PlayLevel4()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X_4");
   }

   public void PlayLevel5()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X_5");
   }

   public void Tutorial()
   {
   	   SceneManager.LoadScene("IndianTrainSim_X");
   }

   public void QuitGame()
   {
	   Debug.Log("quit game");
	   Application.Quit();
   }
}
