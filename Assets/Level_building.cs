using UnityEngine;
using System.Collections;

public class Level_building : MonoBehaviour {

	public Transform wall;
	float time;




    Rigidbody2D obj_1;
   

	bool swwitch = false;

	float left_edge;
	float right_edge;

	void Start()
	{
		wall.GetComponent<Rigidbody2D>().gravityScale = 1;
	
		time = Time.realtimeSinceStartup;


	    left_edge = ((time + 20)-1f);
		right_edge = ((time + 20)+1f);

	}

	void Update () 
	{
		//print (Time.realtimeSinceStartup);
		if (time>=1)
		{

		  if (Time.realtimeSinceStartup > time-1f && Time.realtimeSinceStartup < time+1f)
		  {
		   Instantiate(wall, new Vector3(Random.Range(-15.00f, 38.00f), 78, -0.1f), wall.transform.rotation);
		   time += 2f;
		  }
		}
		else
		{
			if (Time.realtimeSinceStartup > 0 && Time.realtimeSinceStartup < 1)
			{
				Instantiate(wall, new Vector3(Random.Range(-15.00f, 38.00f), 78, -0.1f), wall.transform.rotation);
				time += 2f;
			}
		}

		if (Time.realtimeSinceStartup > left_edge && Time.realtimeSinceStartup < right_edge && swwitch == false)
		{
			wall.GetComponent<Rigidbody2D>().gravityScale += 1;
		

			print("done!");
			swwitch = true;
		}

		if (Time.realtimeSinceStartup > right_edge)
		{
			swwitch = false;
			right_edge+=20;
			left_edge+=20;
		}
	}
}
