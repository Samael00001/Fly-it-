using UnityEngine;
using System.Collections;

public class best_score_script : MonoBehaviour {


	void Start () 
	{
		gameObject.GetComponent<TextMesh>().text = "Best: "+PlayerPrefs.GetInt("best");
	}
	

}
