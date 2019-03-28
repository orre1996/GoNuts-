using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Stats : MonoBehaviour
{

	public static Stats stats;
	Score score;
	StoreSkins store;
	AdManager AdMan;
	TutorialCube tutorialCube;


	public int highscore;
	public int coins;
	public int LastSkins;

	int FirstUnlocked;
	int SecondUnlocked;
	int ThirdUnlocked;
	int FourthUnlocked;
	int FifthUnlocked;
	int SixthUnlocked;
	int SeventhUnlocked;
	int EightUnlocked;
	int NinthUnlocked;
	int TenthUnlocked;
	int EleventhUnlocked;
	int TwelthUnlocked;
	int NormalSkin;
	int LastSkin;

	int DoubleUp;
	int RemoveAds;

	void Awake()
	{
		score = FindObjectOfType<Score>();
		store = FindObjectOfType<StoreSkins>();
		AdMan = FindObjectOfType<AdManager>();
		tutorialCube = FindObjectOfType<TutorialCube>();
		Load();
	}

	 void Start()
	{
		
	}

	public void Save()
	{
		
		//int Highscore = Score..Highscore;
		PlayerPrefs.SetInt("highscore", score.Highscore);

		int coin = score.coins;
		PlayerPrefs.SetInt("coins", coin);

		int LastSkin = store.LastSkin;
		PlayerPrefs.SetInt("LastSkins", LastSkin);

		PlayerPrefs.SetInt("FirstUnlocked", store.FirstUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("SecondUnlocked", store.SecondUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("ThirdUnlocked", store.ThirdUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("FourthUnlocked", store.FourthUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("FifthUnlocked", store.FifthUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("SixthUnlocked", store.SixthUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("SeventhUnlocked", store.SeventhUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("EightUnlocked", store.EightUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("NinthUnlocked", store.NinthUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("TenthUnlocked", store.TenthUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("EleventhUnlocked", store.EleventhUnlocked ? 1 : 0);
		PlayerPrefs.SetInt("TwelthUnlocked", store.TwelthUnlocked ? 1 : 0);

		PlayerPrefs.SetInt("RemoveAds", AdMan.RemoveAds ? 1 : 0);

		

	}

	public void Load()
	{
		score.Highscore = PlayerPrefs.GetInt("highscore");
		score.coins = PlayerPrefs.GetInt("coins");
		store.LastSkin = PlayerPrefs.GetInt("LastSkins");
		
		
		store.FirstUnlocked = (PlayerPrefs.GetInt("FirstUnlocked") != 0);
		store.SecondUnlocked = (PlayerPrefs.GetInt("SecondUnlocked") != 0);
		store.ThirdUnlocked = (PlayerPrefs.GetInt("ThirdUnlocked") != 0);
		store.FourthUnlocked = (PlayerPrefs.GetInt("FourthUnlocked") != 0);
		store.FifthUnlocked = (PlayerPrefs.GetInt("FifthUnlocked") != 0);
		store.SixthUnlocked = (PlayerPrefs.GetInt("SixthUnlocked") != 0);
		store.SeventhUnlocked = (PlayerPrefs.GetInt("SeventhUnlocked") != 0);
		store.EightUnlocked = (PlayerPrefs.GetInt("EightUnlocked") != 0);
		store.NinthUnlocked = (PlayerPrefs.GetInt("NinthUnlocked") != 0);
		store.TenthUnlocked = (PlayerPrefs.GetInt("TenthUnlocked") != 0);
		store.EleventhUnlocked = (PlayerPrefs.GetInt("EleventhUnlocked") != 0);
		store.TwelthUnlocked = (PlayerPrefs.GetInt("TwelthUnlocked") != 0);
		store.NormalSkin = (PlayerPrefs.GetInt("NormalSkin") != 0);
		score.DoubleCoins = (PlayerPrefs.GetInt("DoubleUp") != 0);

		

		AdMan.RemoveAds = (PlayerPrefs.GetInt("RemoveAds") != 0);


	}

	public void DoubleCoinss()
	{
		PlayerPrefs.SetInt("DoubleUp", AdMan.DoubleCoins ? 1 : 0);
	}

	public void RemoveDoubleCoinss()
	{
		PlayerPrefs.DeleteKey("DoubleUp");
	}


	public void Reset()
	{
		PlayerPrefs.DeleteAll();
		score.Highscore = 0;
		score.coins = 0;
		store.ResetProgress();
		score.UpdateCoins();
		AdMan.RemoveAds = true;
		Save();
		
	}

	// Update is called once per frame
	void Update()
	{

	}

}

