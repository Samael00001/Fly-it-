using UnityEngine;
using System.Collections;

public class ok_script : MonoBehaviour {

	//Give_up


	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Vector3 pos = Input.mousePosition;
			//Debug.Log("Mouse pressed " + pos);
			Ray ray = Camera.main.ScreenPointToRay(pos);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 11f))
			{
				//	print (hit.collider.gameObject.name);
				if (hit.collider.gameObject.name == "Try_again")
				{
					PlayerPrefs.SetInt("cur_score", 0);
					Application.LoadLevel("Level");
				}
				else
				{
					if (hit.collider.gameObject.name == "Give_up")
					{
						PlayerPrefs.SetInt("cur_score", 0);
						Application.LoadLevel("Main_menu");
					}
				}

			}
		}
	}
}
