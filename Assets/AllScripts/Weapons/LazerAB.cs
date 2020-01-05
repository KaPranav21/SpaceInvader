using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerAB : MonoBehaviour
{
    Vector2 tempPos;
    
	public Transform firePoint;
	public float cooldownATime;
	private float nextFireTime = 0f;

	public GameObject bulletPrefab;


    // Update is called once per frame
    
	void Start() {
		
	}
	
	
	
	void Update()
    {
		
		if (Time.time > nextFireTime) {
		if (Input.GetButtonDown("Ability1"))   
		{
			
			Shoot();
			nextFireTime = Time.time + cooldownATime ;
		}
	}

		void Shoot ()
		{
			
			tempPos = transform.position;

			tempPos = transform.position;
			Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

			transform.position = tempPos;
			
		}
    }
}