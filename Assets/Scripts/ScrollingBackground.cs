using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	private float ScrollingSpeed;

	public bool StartScrolling = false;


	private WallFalling Fall;
	// Use this for initialization
	void Start () {
		
		Fall = FindObjectOfType<WallFalling>();

	}
	
	// Update is called once per frame
	void Update () {

		
			ScrollingSpeed = Fall.FallingSpeed / 25;
		


		if (StartScrolling == true && transform.position.y > -13.2f)
		{
			transform.position = new Vector2(transform.position.x, transform.position.y + ScrollingSpeed * Time.deltaTime);
		}
	}
}
