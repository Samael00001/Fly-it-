using UnityEngine;
using System.Collections;

public class Player_movement : MonoBehaviour 
{


	public GameObject wall;
	int cur_score = 0;

	void Start()
	{
		PlayerPrefs.SetInt("cur_score", 0);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Trigger")
		{
			cur_score += (int)wall.GetComponent<Rigidbody2D>().gravityScale;
			//print("asd");
			PlayerPrefs.SetInt("cur_score", cur_score);
		}
		
		if(col.gameObject.tag == "wall")
		{
			
			Application.LoadLevel("Game_Over");
		}
	}

	Vector3 temp;
	

}
