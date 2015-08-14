using UnityEngine;
using System.Collections;

public class your_score : MonoBehaviour 
{
	

	void Start () 
	{
	    gameObject.GetComponent<TextMesh>().text = "Your score: "+PlayerPrefs.GetInt("cur_score");
		
	}
	

}
