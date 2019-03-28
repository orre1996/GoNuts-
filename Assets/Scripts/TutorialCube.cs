using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCube : MonoBehaviour {

	public GameObject Cube;

	public Sprite DefaultSkin;
	public Sprite Skin1;
	public Sprite Skin2;
	public Sprite Skin3;
	public Sprite Skin4;
	public Sprite Skin5;
	public Sprite Skin6;
	public Sprite Skin7;
	public Sprite Skin8;
	public Sprite Skin9;
	public Sprite Skin10;
	public Sprite Skin11;
	public Sprite Skin12;




	// Use this for initialization
	void Start () {

		Cube = GameObject.Find("Cube");
		

	}
	
	// Update is called once per frame
	void Update () {
		
		float Distance = Vector2.Distance(transform.position, Cube.transform.position);

		if(Distance < 0.1)
		{
			Destroy(this.gameObject);
		}
	}

	public void ChangeSprite(int Skin)
	{
		switch (Skin)
		{
			
			case 0:
				GetComponent<SpriteRenderer>().sprite = DefaultSkin;
				break;

			case 1:
				GetComponent<SpriteRenderer>().sprite = Skin1;
				break;

			case 2:
				GetComponent<SpriteRenderer>().sprite = Skin2;
				break;

			case 3:
				GetComponent<SpriteRenderer>().sprite = Skin3;
				break;

			case 4:
				GetComponent<SpriteRenderer>().sprite = Skin4;
				break;

			case 5:
				GetComponent<SpriteRenderer>().sprite = Skin5;
				break;

			case 6:
				GetComponent<SpriteRenderer>().sprite = Skin6;
				break;

			case 7:
				GetComponent<SpriteRenderer>().sprite = Skin7;
				break;

			case 8:
				GetComponent<SpriteRenderer>().sprite = Skin8;
				break;

			case 9:
				GetComponent<SpriteRenderer>().sprite = Skin9;
				break;

			case 10:
				GetComponent<SpriteRenderer>().sprite = Skin10;
				break;

			case 11:
				GetComponent<SpriteRenderer>().sprite = Skin11;
				break;

			case 12:
				GetComponent<SpriteRenderer>().sprite = Skin12;
				break;

		}
	}
}
