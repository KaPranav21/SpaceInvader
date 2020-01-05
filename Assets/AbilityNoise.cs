using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityNoise : MonoBehaviour
{
    public Transform firePoint;
	public float cooldownATime;
	private float nextFireTime = 0f;

	private AudioSource mAudioSrc;

	void Start() {
		mAudioSrc = GetComponent<AudioSource>();
	}
	
	void Update() {
	
		if (Time.time > nextFireTime) {
			if (Input.GetButtonDown("Ability1"))   
			{
				mAudioSrc.Play();
				nextFireTime = Time.time + cooldownATime ;
			}
		}
	}
}
