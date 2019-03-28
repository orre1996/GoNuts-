using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	

	public GameObject lTop;
	public GameObject rTop;
	public GameObject lBottom;
	public GameObject rBottom;
	public GameObject gameover;
	public GameObject TutorialCanvas;
	public GameObject DoubleCoinsUI;
	public GameObject Shield;
	public GameObject AimAssist1, AimAssist2;
	public GameObject BirdPowerup;

	[Space]
	[Space]
	public Falling[] fallingThings;

	public TutorialCube[] cube;

	[Space]
	[Space]
	public bool gameover1 = false;
	public bool InMenu = true;
	public bool Rocketing = false;
	bool isWaitingForInput = true;
	public bool jump = false;
	public bool shielded = false;
	public bool AimAssisted = false;
	bool JustMovedRight = false;


	[Space]
	[Space]
	public float IncreaseFallingSpeed = 0;
	public float Timer;
	public float SlowMoSpeed = 0;


	public int JumpSpeed = 6;

	[Space]
	[Space]
	public Animator anim;
	public RuntimeAnimatorController runtime1;

	public enum MoveTarget {topLeft, topRight, botLeft, botRight, falling, rocket};
	MoveTarget GoTarget;

	SpawnRoof Roof;
	Score score;
	MoveTutorialDown MoveTutorial;
	ScrollingBackground Background;
	//public Falling falling;


	void Awake()
	{
		
	}

	// Use this for initialization
	void Start () {
		
		Roof = FindObjectOfType<SpawnRoof>();
		GoTarget = MoveTarget.topRight;
		score = FindObjectOfType<Score>();
		Background = FindObjectOfType<ScrollingBackground>();
		MoveTutorial = FindObjectOfType<MoveTutorialDown>();
		anim = GetComponent<Animator>();
		cube = FindObjectsOfType<TutorialCube>();

		anim.speed = 0;
		
		if (score.DoubleCoins == true)
		{
			DoubleCoinsUI.SetActive(true);
		}
		else
		{
			DoubleCoinsUI.SetActive(false);
		}

	}
	
	void Update() {
		Moving();
		CheckIfPositionReached();

		

		if (InMenu == false && IncreaseFallingSpeed > -2)
		{
			Timer += Time.deltaTime;
			if(Timer > 10)
			{
				IncreaseFallingSpeed -= 0.2f;
				Timer = 0;
			}
		}

		if (Input.GetMouseButtonDown(0) && jump == false && InMenu == false)
		{
			if (AimAssisted == true)
			{
				foreach (Falling go in fallingThings)
				{
					go.GetComponent<Falling>().AimAssist();
				}

				AimAssisted = false;
				AimAssist1.SetActive(false);
				AimAssist2.SetActive(false);
			}

			Jumping();

		}

		
	}

	

	public void StartGame()
	{
		InMenu = false;
		anim.speed = 1;
		TutorialCanvas.SetActive(true);
	}


	void Jumping()
	{
		jump = true;
		isWaitingForInput = false;
		DoubleCoinsUI.SetActive(false);
		SlowMoSpeed = 0;
		Roof.AxePowerup = false;
		Background.StartScrolling = true;

		
	}


	void CheckIfPositionReached()
	{

		if (transform.position == lTop.transform.position)
		{
			transform.eulerAngles = new Vector3(0, 0, -90);
			anim.SetInteger("Jump", 0);
			Invoke("NextTarget", 0.5f);
		}

		if (transform.position == lBottom.transform.position && isWaitingForInput == false)
		{
			NextTarget();
			Roof.NewRoof();
			isWaitingForInput = true;
			if(AimAssisted == true)
			{
				AimAssist2.SetActive(true);

			}
		}

		if (transform.position == rTop.transform.position)
		{
			transform.eulerAngles = new Vector3(0, 0, -90);
			anim.SetInteger("Jump", 0);
			Invoke("NextTarget", 0.5f);
		}

		if (transform.position == rBottom.transform.position && isWaitingForInput == false)
		{
			NextTarget();
			Roof.NewRoof();
			isWaitingForInput = true;
			if (AimAssisted == true)
			{
				AimAssist1.SetActive(true);
				
			}
		}
	}


	void Moving()
	{
		if (jump == true && GoTarget == MoveTarget.topLeft && isWaitingForInput == false && transform.position != lTop.transform.position)
		{
			transform.position = Vector3.MoveTowards(transform.position, lTop.transform.position, JumpSpeed * Time.deltaTime);
			transform.localScale = new Vector3(0.1f, 0.1f);
			anim.SetInteger("Jump", 1);
			transform.eulerAngles = new Vector3(0,0,0);
		}

		if (jump == true && GoTarget == MoveTarget.topRight && isWaitingForInput == false && transform.position != rTop.transform.position)
		{
			transform.position = Vector3.MoveTowards(transform.position, rTop.transform.position, JumpSpeed * Time.deltaTime);
			transform.localScale = new Vector3(0.1f, -0.1f);
			anim.SetInteger("Jump", 1);
			transform.eulerAngles = new Vector3(0, 0, -180);
		}

		if (GoTarget == MoveTarget.botLeft && jump == true && transform.position != lBottom.transform.position)
		{
			transform.position = Vector3.MoveTowards(transform.position, lBottom.transform.position, JumpSpeed * Time.deltaTime);
			
		}

		if (GoTarget == MoveTarget.botRight && jump == true && transform.position != rBottom.transform.position) 
		{
			transform.position = Vector3.MoveTowards(transform.position, rBottom.transform.position, JumpSpeed * Time.deltaTime);
			

		}

		if(GoTarget == MoveTarget.falling)
		{
			transform.position = new Vector2(transform.position.x, transform.position.y - JumpSpeed * Time.deltaTime);
		}


	}

	void NextTarget()
	{
		CancelInvoke();
		MoveTutorial.StartMoving();

		foreach (Falling go in fallingThings)
		{
			if (go != null)
			{
				go.GetComponent<Falling>().StopAimAssist();
			}
		}


		if (GoTarget == MoveTarget.topLeft)
		{
			GoTarget = MoveTarget.botLeft;
			return;
		}

		else if (GoTarget == MoveTarget.botLeft)
		{
			GoTarget = MoveTarget.topRight;
			JustMovedRight = true;
			jump = false;
			return;
		}
		
		else if (GoTarget == MoveTarget.topRight)
		{
			GoTarget = MoveTarget.botRight;
			return;
		}

		else if (GoTarget == MoveTarget.botRight)
		{
			jump = false;
			JustMovedRight = false;
			GoTarget = MoveTarget.topLeft;
			return;
		}
		
		

	}

	public void FindAllRooves()
	{
		fallingThings = GameObject.FindObjectsOfType<Falling>();
	}

	public void RocketingDone()
	{
		Rocketing = false;
		BirdPowerup.SetActive(false);

		if (JustMovedRight == true)
		{
			GoTarget = MoveTarget.topRight;
		}

		else if (JustMovedRight == false)
		{
			GoTarget = MoveTarget.topLeft;
		}

	}

	public void HitRoof()
	{
		GoTarget = MoveTarget.falling;
	}

	public void RocketState()
	{
		GoTarget = MoveTarget.rocket;
	}
}
