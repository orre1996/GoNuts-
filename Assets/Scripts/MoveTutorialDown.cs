using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTutorialDown : MonoBehaviour {

	public bool MoveDown = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(MoveDown == true)
		{
			transform.position -= new Vector3(0, 6 * Time.deltaTime);
		}
	}

	public void StartMoving()
	{
		MoveDown = true;
	}
}
