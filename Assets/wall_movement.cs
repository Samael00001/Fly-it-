using UnityEngine;
using System.Collections;

public class wall_movement : MonoBehaviour {

	
	Vector3 temp;

	void Update () 
	{
		temp = gameObject.transform.position;
		temp.y -= 10 * Time.deltaTime;
		gameObject.transform.position = temp;
	}
}
