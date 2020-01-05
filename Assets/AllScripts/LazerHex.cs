using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHex : MonoBehaviour
{
    public float speed = 20f;
	public float coolDownAbility;
	private float nextUseTime = 5;
	public int damage = 6;
	public Rigidbody2D rbi;
	
    void Start()
    {
		rbi.velocity = transform.up * speed;    
    }


	void OnTriggerEnter2D(Collider2D hitReg)
	{	
		
		Enemy enemy = hitReg.GetComponent<Enemy>();	
		if (hitReg.gameObject.tag.Equals("BulletBreak"))
		{
			Destroy(gameObject);
		}
		
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}
		
	}
}