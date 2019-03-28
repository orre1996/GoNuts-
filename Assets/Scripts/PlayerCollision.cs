using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	Jump jump;
	SpawnRoof Roof;
	Score score;
	Stats stats;
	MoveTutorialDown MoveTutorial;
	AdManager adman;


	// Use this for initialization
	void Start () {

		jump = FindObjectOfType<Jump>();
		Roof = FindObjectOfType<SpawnRoof>();
		stats = FindObjectOfType<Stats>();
		score = FindObjectOfType<Score>();
		adman = FindObjectOfType<AdManager>();
	}
	
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Roof")
		{
			if (jump.Rocketing == true)
			{
				other.GetComponent<SpriteRenderer>().enabled = false;
			}

			else if (jump.shielded == true)
			{
				Destroy(other.gameObject);
				jump.Shield.SetActive(false);
				jump.shielded = false;
			}

			else
			{
				jump.HitRoof();
				


			}
		}

		if (other.tag == "die")
		{

			jump.gameover1 = true;
			jump.gameover.SetActive(true);
			adman.RandomAd();
			score.UpdateGameoverUI();
			stats.RemoveDoubleCoinss();
			stats.Save();


		}

		if (other.tag == "ScoreLine")
		{
			score.IncreaseScore();
		}

		if (other.tag == "Shield")
		{
			jump.Shield.SetActive(true);
			jump.shielded = true;
		}

		if (other.tag == "AimAssist")
		{

			jump.AimAssisted = true;
		}

		if (other.tag == "SlowMo")
		{
			jump.SlowMoSpeed = -1f;
		}

		if (other.tag == "Rocket")
		{
			jump.RocketState();
			jump.Rocketing = true;
			jump.BirdPowerup.SetActive(true);
			StartCoroutine(Roof.RocketPowerup());

		}

		if (other.tag == "Axe")
		{
			Roof.AxePowerup = true;
		}
	}

}
