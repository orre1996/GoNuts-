using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoof : MonoBehaviour
{
	public GameObject LeftRoof, RightRoof;
	public GameObject Coin, TripleCoin, Shield, AimAssist, SlowMo, Rocket, Axe; // Powerups
	


	private bool StartSpawn = false;
	public bool AxePowerup = true;

	private Vector2 Position = Vector2.zero;


	private float Roof2xPos;
	private float CoinXPosition;
	public float CoinOrPowerup = 0;
	public float MinimumGap = 6.25f;

	[Header("Between given number and 10")]
	public float CoinDroprate;
	[Header("Between given number and 0")]
	public float PowerUpDropRate;

	
	private int RandomPowerup;
	private int TypeOfCoin;
	[Space]
	[Space]
	public int CutBranch = 0;
	public int Handicap = 0;


	

	public List<GameObject> Rooves = new List<GameObject>();

	Jump jump;

	// Use this for initialization
	void Start()
	{
		jump = FindObjectOfType<Jump>();

	}

	// Update is called once per frame
	void Update()
	{

		if (StartSpawn == true)
		{
			NewRoof();
			
		}
		
	}
	
	public void StartGame()
	{
		Invoke("NewRoof", 2);
	}

	public void NewRoof()
	{
		if (Handicap <= 4)
		{

			Handicap++;
			HandicapBranches();
		}

		else
		{

			if (AxePowerup == true)
			{
				AxePowerupBranches();
			}

			else
			{

				if (Random.value <= 0.5)
				{
					RightSideRoof();
				}
				else
				{
					LeftSideRoof();
				}


				
			}
		}
		jump.FindAllRooves();
	}

	public void LeftSideRoof()
	{
		Position = new Vector2(Random.Range( -MinimumGap,  -9.75f), 5.0f);
		Roof2xPos = Random.Range(8.6f, 12f);

		
		

		if (Roof2xPos + Position.x < 2.3f)  // If left roof is too long to the left
		{

			
				Instantiate(RightRoof, new Vector2(Roof2xPos, Position.y), Quaternion.identity);
			
				Instantiate(LeftRoof, new Vector2(2.7f, Position.y), Quaternion.identity);
			
				CoinXPosition = (2.3f + Roof2xPos) / 2;
			

		}
		else // if they're both in the middle // båda
		{
			
				Instantiate(RightRoof, new Vector2(Roof2xPos, Position.y), Quaternion.identity);
			
				Instantiate(LeftRoof, new Vector2(Roof2xPos + Position.x, Position.y), Quaternion.identity);
			
				CoinXPosition = (Position.x / 2) + Roof2xPos;
			

		}

		CoinOrPowerup = Random.Range(1, 10);

		if (CoinOrPowerup <= PowerUpDropRate && jump.Rocketing == false)
		{
			SpawnPowerup();
		}

		if (CoinOrPowerup >= CoinDroprate && jump.Rocketing == false)
		{
			SpawnCoin();
		}
	}

	void RightSideRoof()
	{

		Position = new Vector2(Random.Range(2.5f, 6f), 5.0f);
		Roof2xPos = Random.Range(MinimumGap, 10);

		

		if (Position.x + Roof2xPos > 12f) // If right roof if too long to the right
		{
			
				Instantiate(LeftRoof, new Vector2(Position.x, Position.y), Quaternion.identity);
			
				Instantiate(RightRoof, new Vector2(12f, Position.y), Quaternion.identity);
			
				CoinXPosition = (Position.x + 12f) / 2;
			

		}

		else // If they're both in the middle
		{
			
				Instantiate(LeftRoof, Position, Quaternion.identity);
			
				Instantiate(RightRoof, new Vector2((Position.x + Roof2xPos), Position.y), Quaternion.identity);
			
				CoinXPosition = Position.x + Roof2xPos / 2;
			

		}

		CoinOrPowerup = Random.Range(1, 10);

		if (CoinOrPowerup <= PowerUpDropRate && jump.Rocketing == false)
		{
			SpawnPowerup();
		}

		if (CoinOrPowerup >= CoinDroprate && jump.Rocketing == false)
		{
			SpawnCoin();
		}


	}

	public void SpawnCoin()
	{
		TypeOfCoin = Random.Range(0, 10);

		if(TypeOfCoin <= 8)
		{
			Instantiate(Coin, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);
		}

		else if (TypeOfCoin > 8)
		{
			Instantiate(TripleCoin, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);
		}


		
	}

	public void SpawnPowerup()
	{
		RandomPowerup = Random.Range(0 , 5);
		switch (RandomPowerup)
		{
			case 0:
				
				if (jump.shielded == false)
				{
					Instantiate(Shield, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);
				}

				else
				{
					SpawnPowerup();
				}

				break;

			case 1:

				Instantiate(AimAssist, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);

				break;

			case 2:
				

				Instantiate(SlowMo, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);

				break;

			case 3:


				Instantiate(Rocket, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);

				break;

			case 4:


				Instantiate(Axe, new Vector2(CoinXPosition, 5.0f), Quaternion.identity);

				break;

		}
	}

	public IEnumerator RocketPowerup()
	{
		for (int i = 0; i < 4; i++)
		{
			NewRoof();
			yield return new WaitForSeconds(0.5f);
		}

		yield return new WaitForSeconds(2);
		jump.RocketingDone();
	}

	public void AxePowerupBranches()
	{
			Instantiate(RightRoof, new Vector2(12, Position.y), Quaternion.identity);
	
			Instantiate(LeftRoof, new Vector2(2.3f, Position.y), Quaternion.identity);

			CoinXPosition = (12 + 2.3f) / 2;

		if (CoinOrPowerup <= PowerUpDropRate && jump.Rocketing == false)
		{
			SpawnPowerup();
		}

		if (CoinOrPowerup >= CoinDroprate && jump.Rocketing == false)
		{
			SpawnCoin();
		}
	}

	public void HandicapBranches()
	{
		Position = new Vector2(Random.Range(2.5f, 3.5f), 5.0f);
		Roof2xPos = Random.Range(11.2f, 12);



		if (Position.x + Roof2xPos > 12f) // If right roof if too long to the right
		{

			Instantiate(LeftRoof, new Vector2(Position.x, Position.y), Quaternion.identity);

			Instantiate(RightRoof, new Vector2(Roof2xPos, Position.y), Quaternion.identity);

			CoinXPosition = (Position.x + Roof2xPos) / 2;


			if (CoinOrPowerup <= PowerUpDropRate && jump.Rocketing == false)
			{
				SpawnPowerup();
			}

			if (CoinOrPowerup >= CoinDroprate && jump.Rocketing == false)
			{
				SpawnCoin();
			}

		}
	}
}

	

