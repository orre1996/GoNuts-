using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour {

	public float FallingSpeed = -2;
	public float IncreaseFallingSpeed1 = 0;
	public float SlowMoSpeed;
	
	public GameObject Player;
	public Jump jump;
	public WallFalling[] wallFall;

	public bool stop = false;
	// Use this for initialization
	void Start () {
		wallFall = FindObjectsOfType<WallFalling>();
		Player = GameObject.Find("Cube");
		jump = FindObjectOfType<Jump>();
		SlowMoSpeed = jump.SlowMoSpeed;
		IncreaseFallingSpeed1 = jump.IncreaseFallingSpeed;

		foreach(WallFalling go in wallFall)
		{
			go.FindRoofSpeed();
		}

		FallingSpeed = (FallingSpeed + IncreaseFallingSpeed1 - SlowMoSpeed);
	}
	
	// Update is called once per frame
	void Update () {

		

		if (Player != null)
		{
			if (transform.position.y < Player.transform.position.y || jump.Rocketing == true)
			{
				FallingSpeed = -5;
			}
			else if (stop == true)
			{
				FallingSpeed = 0;
			}

			
			
		}
		else
		{
			FallingSpeed = -2 + (IncreaseFallingSpeed1 - SlowMoSpeed);
		}
			
		transform.position = new Vector3(transform.position.x ,transform.position.y + FallingSpeed * Time.deltaTime);

	}

	public void AimAssist()
	{
		stop = true;
	}

	public void StopAimAssist()
	{
		stop = false;
		FallingSpeed = ( -2 + IncreaseFallingSpeed1 - SlowMoSpeed);
	}
}
