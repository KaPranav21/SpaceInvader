using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riser2 : MonoBehaviour
{

    // Start is called before the first frame update

	Vector2 tempPos;
	public float levelSpeed;

    void Start()
    {
		
		
    }

    // Update is called once per frame
    void Update()
    {
			tempPos = transform.position;

			tempPos.y += levelSpeed;

			transform.position = tempPos;
    }
}

