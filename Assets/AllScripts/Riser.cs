using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riser : MonoBehaviour
{

    // Start is called before the first frame update

	Vector2 tempPos;

    void Start()
    {
		
		
    }

    // Update is called once per frame
    void Update()
    {
			tempPos = transform.position;

			tempPos.y += 0.03f;

			transform.position = tempPos;
    }
}

