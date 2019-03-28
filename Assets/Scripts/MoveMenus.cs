using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenus : MonoBehaviour {

	public GameObject Menu, Shop, Acorns;

	enum MenuPositions { StartMenu, ShopMenu, AcornsMenu }

	public float speed = 5;

	MenuPositions positions;
	// Use this for initialization
	void Start () {
		positions = MenuPositions.StartMenu;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(positions == MenuPositions.StartMenu)
		{
			transform.position = Vector3.MoveTowards(transform.position, Menu.transform.position, speed * Time.deltaTime);
		}

		else if (positions == MenuPositions.ShopMenu)
		{
			transform.position = Vector3.MoveTowards(transform.position, Shop.transform.position, speed * Time.deltaTime);
		}

		else if (positions == MenuPositions.AcornsMenu)
		{
			transform.position = Vector3.MoveTowards(transform.position, Acorns.transform.position, speed * Time.deltaTime);
		}
	}

	public void ChangeToShopFromStartmenu()
	{
		positions = MenuPositions.ShopMenu;
	}

	public void ChangeToShopFromAcorns()
	{
		positions = MenuPositions.AcornsMenu;
	}

	public void ChangeToStartFromShop()
	{
		positions = MenuPositions.StartMenu;
	}

	public void ChangeToAcornsFromShop()
	{
		positions = MenuPositions.ShopMenu;
	}
}
