using UnityEngine;
using System.Collections;

public class destroyer : MonoBehaviour 
{

	void OnCollisionEnter2D (Collision2D col)
	{
		Destroy(col.gameObject);
	}
}
