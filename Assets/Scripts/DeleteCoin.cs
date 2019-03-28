using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCoin : MonoBehaviour {

	public Score score;
	public StoreSkins store;

	public int AmountOfCoins;
	// Use this for initialization
	void Start () {
		score = FindObjectOfType<Score>();
		store = FindObjectOfType<StoreSkins>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			score.CoinsCount(AmountOfCoins);
			score.UpdateCoins();
			Destroy(gameObject);
		}

		if (other.tag == "die")
		{
			Destroy(gameObject);
		}
	}
}
