using UnityEngine;
using System.Collections;

public class play_Button : MonoBehaviour {



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
				if (hit.collider.gameObject.name == "Play")
				{
					Application.LoadLevel("Level");
				}
				else
				{
					if (hit.collider.gameObject.name == "Exit")
					{
					   print ("Exit!");
					   Application.Quit();
					}
				}
			}
		}
	}
}
