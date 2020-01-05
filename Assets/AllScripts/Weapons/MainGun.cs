using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGun : MonoBehaviour
{
    Vector2 tempPos;
    
	public Transform firePoint;
	public float cooldownTime;
	private float nextFireTime = 0f;

	public GameObject bulletPrefab;
	private AudioSource mAudioSrc;

    // Update is called once per frame
    
	void Start() {
		mAudioSrc = GetComponent<AudioSource>();
	}
	
	
	
	void Update()
    {
		
		if (Time.time > nextFireTime) {
		if (Input.GetButtonDown("Jump"))   
		{
			mAudioSrc.Play();
			Shoot();
			nextFireTime = Time.time + cooldownTime ;
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
