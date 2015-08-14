using UnityEngine;
using System.Collections;

public class best_score : MonoBehaviour {
	
	void Start () 
	{


		if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("cur_score"))
		{
			PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("cur_score"));
			gameObject.GetComponent<TextMesh>().text = "Best: "+PlayerPrefs.GetInt("cur_score") +" (NEW!)";
		}
		else
		{
			gameObject.GetComponent<TextMesh>().text = "Best: "+PlayerPrefs.GetInt("best");
		}


	}

}
