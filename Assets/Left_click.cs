using UnityEngine;
using System.Collections;

public class Left_click : MonoBehaviour 
{

	public GameObject Player;
	Vector3 temp;

	/*void OnMouseOver()
	{
		if (Input.GetMouseButton(0) && Player.transform.position.x >= -26.7f)
		{
			temp = Player.transform.position;
			temp.x -= 100 * Time.deltaTime;
			Player.transform.position = temp;	
		}
	}*/
	


	void Update () {
		
		if (Input.GetMouseButton(0))
		{
			Vector3 pos = Input.mousePosition;
			//Debug.Log("Mouse pressed " + pos);
			Ray ray = Camera.main.ScreenPointToRay(pos);
			RaycastHit hit;

			//print ("!!!");
			if (Physics.Raycast(ray, out hit, 11f))
			{
			//	print (hit.collider.gameObject.name);
				if (hit.collider.gameObject.name == "Left_Button" && Player.transform.position.x >= -26.7f)
				{
				temp = Player.transform.position;
				temp.x -= 100 * Time.deltaTime;
				Player.transform.position = temp;	
				//Debug.Log("Something hit");
				}
				else
				{
					
					if (hit.collider.gameObject.name == "Right_Button" && Player.transform.position.x <= 26.7f)
					{
						temp = Player.transform.position;
						temp.x += 100 * Time.deltaTime;
						Player.transform.position = temp;	
						//Debug.Log("Something hit");
					}
				}
			}

			
		}
	}


	
}
