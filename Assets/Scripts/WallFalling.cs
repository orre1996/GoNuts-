using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFalling : MonoBehaviour {


	public float FallingSpeed = -2;

	Falling fall;
	Jump jump;


	// Use this for initialization
	void Start () {
		jump = FindObjectOfType<Jump>();
	}
	
	// Update is called once per frame
	void Update () {

		if (jump.InMenu == true)
		{
			FallingSpeed = 0;
		}

		else
		{
			FallingSpeed = -jump.JumpSpeed;


			if (fall != null)
			{
				FallingSpeed = fall.FallingSpeed;
			}
		}
		transform.position = new Vector2(transform.position.x, transform.position.y + FallingSpeed * Time.deltaTime);

		if(transform.position.y < -16)
		{
			transform.position = new Vector2(transform.position.x, 18f);
		}
	}

	public void FindRoofSpeed()
	{
		fall = FindObjectOfType<Falling>();
	}
}
