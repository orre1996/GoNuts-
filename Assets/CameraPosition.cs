using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

	public GameObject IngamePos;
	public GameObject MenuPos;

	public enum CameraStates { Menu, Ingame};
	CameraStates CameraState;


	

	// Use this for initialization
	void Start () {

		CameraState = CameraStates.Menu;
		transform.position = MenuPos.transform.position;
	}
	
	// Update is called once per frame
	void Update () {


		if (CameraState == CameraStates.Menu && MenuPos != null)
		{

			transform.position = Vector3.Lerp(transform.position, MenuPos.transform.position, 2 * Time.deltaTime);
			Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 3.5f, 2 * Time.deltaTime);


		}
		else if (CameraState == CameraStates.Ingame && IngamePos != null)
		{
			transform.position = Vector3.Lerp(transform.position, IngamePos.transform.position, 2 * Time.deltaTime);
			Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5.2f, 2 * Time.deltaTime);
			
		}
		
	}

	public void MoveCam()
	{
		if(CameraState == CameraStates.Menu)
		{
			CameraState = CameraStates.Ingame;
		}
		else if (CameraState == CameraStates.Ingame)
		{
			CameraState = CameraStates.Menu;
		}
	}
}
