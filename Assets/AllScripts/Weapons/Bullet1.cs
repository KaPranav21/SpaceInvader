using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed = 30f;
	public float coolDownAbility;
	private float nextUseTime = 5;
	public int damage = 30;
	public Rigidbody2D rb;

    void Start()
    {
		rb.velocity = transform.up * speed;    
    }


	void OnTriggerEnter2D(Collider2D hitReg)
	{	
		
		Enemy enemy = hitReg.GetComponent<Enemy>();	
		Destroy(gameObject);
		
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}
		
	}
}
