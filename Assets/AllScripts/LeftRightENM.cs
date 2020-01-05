using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightENM : MonoBehaviour
{
    public float speed;
	public GameObject [] points;
	int curr = 1;
	public float Dist = 1;

    // Update is called once per frame
    void Update()
    {
		if (Vector3.Distance(points[curr].transform.position, transform.position) < Dist)
		{
			curr++;
			if (curr >= points.Length)
			{
				curr = 0;
			}
		}
        transform.position = Vector3.MoveTowards(transform.position, points[curr].transform.position, Time.deltaTime * speed);
    }
}
