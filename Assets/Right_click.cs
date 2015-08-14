using UnityEngine;
using System.Collections;

public class Right_click : MonoBehaviour {

	public GameObject Player;
	Vector3 temp;

	/*void OnMouseOver()
	{
		if (Input.GetMouseButton(0) && Player.transform.position.x <= 26.7f)
		{
			temp = Player.transform.position;
			temp.x += 100 * Time.deltaTime;
			Player.transform.position = temp;	
		}
	}*/

	private void Update()
	{
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began && Player.transform.position.x <= 26.7f)
			{
				temp = Player.transform.position;
				temp.x += 100 * Time.deltaTime;
				Player.transform.position = temp;	
			}
			//TODO: Use additional touch phases for other logic.
		}
	}
	

}
