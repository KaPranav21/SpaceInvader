using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CammeraFollow2d : MonoBehaviour
{
	[SerializeField]
	GameObject demo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(1, demo.transform.position.y+2,-5);
    }
}
