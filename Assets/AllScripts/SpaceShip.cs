using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

	public float speed = 30;
	int health = 3;

	//public GameObject theBullet;

	void FixedUpdate()
	{
		float horzMove = Input.GetAxisRaw("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove, 4) * speed; 
	}
	
	
    
	
	
	// Update is called once per frame
    void Update()
    {
             }
}