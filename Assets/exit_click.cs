using UnityEngine;
using System.Collections;

public class exit_click : MonoBehaviour {

	void OnMouseOver()
	{
		
		
		if (Input.GetMouseButtonDown(0))
		{
			print ("Exit!");
			Application.Quit();
		}
	}
}
