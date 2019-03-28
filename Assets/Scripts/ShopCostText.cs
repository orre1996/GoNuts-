using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCostText : MonoBehaviour {
	

	public int SkinCost;

	StoreSkins store;
	// Use this for initialization
	void Start () {
		store = FindObjectOfType<StoreSkins>();

		
		if (SkinCost == 1)
		{
			GetComponent<Text>().text = store.FirstLevelSkins.ToString();
		}
		else if(SkinCost == 2)
		{
			GetComponent<Text>().text = store.SecondLevelSkins.ToString();
		}

		else if (SkinCost == 3)
		{
			GetComponent<Text>().text = store.ThirdLevelSkins.ToString();
		}

		else if (SkinCost == 4)
		{
			GetComponent<Text>().text = store.FourthLevelSkins.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
