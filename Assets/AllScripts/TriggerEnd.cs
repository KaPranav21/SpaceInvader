using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
   public int c = 0;
   
   

   void OnTriggerEnter2D (Collider2D col)
   {
   	   
	   
	   if(col.gameObject.tag.Equals("Player1"))
	   {
			Time.timeScale = 0;
			c++;
			
			if (c == 1){
			
			}
	}
	   }

	
}
