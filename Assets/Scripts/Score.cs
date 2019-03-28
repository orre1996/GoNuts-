using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {
	public int score = 0;
	public int coins = 0;
	public int Highscore = 0;
	public bool gameover = false;
	public bool DoubleCoins = false;

	public GameObject Player;


	public Text ScoreText;
	public Text CoinsText;
	public GameObject TestText;
	public Text ScoreGameOver;
	public Text HighScoreGameOver;
	public Text GameoverNewHighScore;
	
	public static Score Instance { set; get; }
	// Use this for initialization

	void Awake()
	{
		Instance = this;
		TestText = GameObject.Find("HUDCanvas/IngameUI/Coins");
		CoinsText = TestText.GetComponent<Text>();
		
	}

	void Start () {

		Player = GameObject.Find("Cube");
		UpdateScore();
		UpdateCoins();
		gameover = GetComponent<Jump>().gameover1;


		

	}


	// Update is called once per frame
	void Update () {
		
	}
	public void IncreaseScore()
	{
		score++;
		UpdateScore();
	}

	void UpdateScore()
	{
		ScoreText.text = "" + score.ToString();
	}

	public void UpdateCoins()
	{
		CoinsText.text = "" + coins.ToString();
	}

	public void CoinsCount(int AmountOfCoins)
	{

		if(DoubleCoins == true)
		{
			coins += (AmountOfCoins * 2);
		}
		else if (DoubleCoins == false)
		{
			coins += AmountOfCoins;
		}
		UpdateCoins();
	}

	public void UpdateGameoverUI()
	{
		ScoreGameOver.text = score.ToString();
		GameoverNewHighScore.text = "Game Over";
		if(score > Highscore)
		{
			Highscore = score;
			GameoverNewHighScore.text = "New Highscore";

		}
		HighScoreGameOver.text = Highscore.ToString();
	}
}
