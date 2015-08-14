using UnityEngine;
using System.Collections;

public class try_again : MonoBehaviour {

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PlayerPrefs.SetInt("cur_score", 0);
			Application.LoadLevel("Level");
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			PlayerPrefs.SetInt("cur_score", 0);
			Application.LoadLevel("Level");
		}
	}
}
