using UnityEngine;
using System.Collections;

public class score_live : MonoBehaviour {

	TextMesh live_score;

	void Start () 
	{
		live_score = gameObject.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		live_score.text = "Score: "+PlayerPrefs.GetInt("cur_score");
	}
}
