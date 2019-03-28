using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreSkins : MonoBehaviour {

	public SpriteRenderer SpriteRend;

	public bool FirstUnlocked = false;
	public bool SecondUnlocked = false;
	public bool ThirdUnlocked = false;
	public bool FourthUnlocked = false;
	public bool FifthUnlocked = false;
	public bool SixthUnlocked = false;
	public bool SeventhUnlocked = false;
	public bool EightUnlocked = false;
	public bool NinthUnlocked = false;
	public bool TenthUnlocked = false;
	public bool EleventhUnlocked = false;
	public bool TwelthUnlocked = false;
	public bool NormalSkin = false;

	[Space]
	[Space]
	[Header("Buttons")]
	public GameObject Button1;
	public GameObject Button2;
	public GameObject Button3;
	public GameObject Button4;
	public GameObject Button5;
	public GameObject Button6;
	public GameObject Button7;
	public GameObject Button8;
	public GameObject Button9;
	public GameObject Button10;
	public GameObject Button11;
	public GameObject Button12;
	public GameObject NormalSkinButton;

	[Space]
	[Space]
	[Header("Button Images")]
	public Button image1;
	public Button image2;
	public Button image3;
	public Button image4;
	public Button image5;
	public Button image6;
	public Button image7;
	public Button image8;
	public Button image9;
	public Button image10;
	public Button image11;
	public Button image12;
	public Button NormalSkinButtons;


	[Space]
	[Space]
	[Header("Skins")]
	public RuntimeAnimatorController DefaultSkin;
	public RuntimeAnimatorController Skin1;
	public RuntimeAnimatorController Skin2;
	public RuntimeAnimatorController Skin3;
	public RuntimeAnimatorController Skin4;
	public RuntimeAnimatorController Skin5;
	public RuntimeAnimatorController Skin6;
	public RuntimeAnimatorController Skin7;
	public RuntimeAnimatorController Skin8;
	public RuntimeAnimatorController Skin9;
	public RuntimeAnimatorController Skin10;
	public RuntimeAnimatorController Skin11;
	public RuntimeAnimatorController Skin12;

	[Space]
	[Space]
	[Header("Button images")]
	public Sprite DefaultSkinButton;
	public Sprite ButtonSkin1;
	public Sprite ButtonSkin2;
	public Sprite ButtonSkin3;
	public Sprite ButtonSkin4;
	public Sprite ButtonSkin5;
	public Sprite ButtonSkin6;
	public Sprite ButtonSkin7;
	public Sprite ButtonSkin8;
	public Sprite ButtonSkin9;
	public Sprite ButtonSkin10;
	public Sprite ButtonSkin11;
	public Sprite ButtonSkin12;



	Score coin;
	Stats stats;
	Jump jump;
	TutorialCube[] tutorialCube;

	public Animator anim;

	[Space]
	[Space]

	public int coins = 0;
	public int LastSkin = 0;
	public int FirstLevelSkins = 25;
	public int SecondLevelSkins = 75;
	public int ThirdLevelSkins = 150;
	public int FourthLevelSkins = 300;

	// Use this for initialization
	void Start()
	{
		SpriteRend = GetComponent<SpriteRenderer>();
		coin = FindObjectOfType<Score>();
		stats = FindObjectOfType<Stats>();
		anim = GetComponent<Animator>();
		tutorialCube = FindObjectsOfType<TutorialCube>();


		switch (LastSkin)
		{

			case 0:
				anim.runtimeAnimatorController = DefaultSkin;


				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(0);
				}

				break;

			case 1:
				anim.runtimeAnimatorController = Skin1;


				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(1);
				}


				break;

			case 2:
				anim.runtimeAnimatorController = Skin2;


				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(2);
				}


				break;

			case 3:
				anim.runtimeAnimatorController = Skin3;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(3);
				}

				//Button3.SetActive(false);
				//image3.GetComponent<Image>().sprite = ButtonSkin3;
				break;

			case 4:
				anim.runtimeAnimatorController = Skin4;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(4);
				}

				//Button4.SetActive(false);
				//image4.GetComponent<Image>().color = Color.yellow;
				break;

			case 5:
				anim.runtimeAnimatorController = Skin5;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(5);
				}

				//Button5.SetActive(false);
				//image5.GetComponent<Image>().color = Color.blue;
				break;

			case 6:
				anim.runtimeAnimatorController = Skin6;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(6);
				}

				//Button6.SetActive(false);
				//image6.GetComponent<Image>().color = Color.cyan;
				break;

			case 7:
				anim.runtimeAnimatorController = Skin7;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(7);
				}

				//Button7.SetActive(false);
				//image7.GetComponent<Image>().color = Color.magenta;
				break;

			case 8:
				anim.runtimeAnimatorController = Skin8;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(8);
				}

				//Button8.SetActive(false);
				//image8.GetComponent<Image>().color = Color.gray;
				break;

			case 9:
				anim.runtimeAnimatorController = Skin9;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(9);
				}

				//Button9.SetActive(false);
				//image9.GetComponent<Image>().color = Color.gray;
				break;

			case 10:
				anim.runtimeAnimatorController = Skin10;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(10);
				}

				//Button10.SetActive(false);
				//image10.GetComponent<Image>().color = Color.red;
				break;

			case 11:
				anim.runtimeAnimatorController = Skin11;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(11);
				}

				//Button11.SetActive(false);
				//image11.GetComponent<Image>().color = Color.white;
				break;

			case 12:
				anim.runtimeAnimatorController = Skin12;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.ChangeSprite(12);
				}

				//Button12.SetActive(false);
				//image12.GetComponent<Image>().color = Color.red;
				break;

			

		}


		if (FirstUnlocked == true)
		{
			//SpriteRend.color = Color.white;
			Button1.SetActive(false);
			//image1.GetComponent<Image>().sprite = ButtonSkin1;
		}



		if (SecondUnlocked == true)
		{
			//SpriteRend.color = Color.red;
			Button2.SetActive(false);
			//image2.GetComponent<Image>().sprite = ButtonSkin2;
		}



		if (ThirdUnlocked == true)
		{
			//SpriteRend.color = Color.green;
			Button3.SetActive(false);
			//image3.GetComponent<Image>().sprite = ButtonSkin3;
		}


		if (FourthUnlocked == true)
		{
		//	SpriteRend.color = Color.yellow;
			Button4.SetActive(false);
			//image4.GetComponent<Image>().sprite = ButtonSkin4;
		}



		if (FifthUnlocked == true)
		{
			//SpriteRend.color = Color.blue;
			Button5.SetActive(false);
			//image5.GetComponent<Image>().sprite = ButtonSkin5;
		}


		if (SixthUnlocked == true)
		{
			//SpriteRend.color = Color.cyan;
			Button6.SetActive(false);
			//image6.GetComponent<Image>().sprite = ButtonSkin6;
		}


		if (SeventhUnlocked == true)
		{
			//SpriteRend.color = Color.magenta;
			Button7.SetActive(false);
			//image7.GetComponent<Image>().sprite = ButtonSkin7;
		}



		if (EightUnlocked == true)
		{
			//SpriteRend.color = Color.gray;
			Button8.SetActive(false);
			//image8.GetComponent<Image>().sprite = ButtonSkin8;
		}



		if (NinthUnlocked == true)
		{
			//SpriteRend.color = Color.grey;
			Button9.SetActive(false);
			//image9.GetComponent<Image>().sprite = ButtonSkin9;
		}



		if (TenthUnlocked == true)
		{
			//SpriteRend.color = Color.red;
			Button10.SetActive(false);
			//image10.GetComponent<Image>().sprite = ButtonSkin10;
		}


		if (EleventhUnlocked == true)
		{
			//SpriteRend.color = Color.white;
			Button11.SetActive(false);
			//image11.GetComponent<Image>().sprite = ButtonSkin11;
		}



		if (TwelthUnlocked == true)
		{
			//.color = Color.red;
			Button12.SetActive(false);
			//image12.GetComponent<Image>().sprite = ButtonSkin12;
		}

		if (NormalSkin == true)
		{
			//SpriteRend.color = Color.black;
		}

	}
			

	
	// Update is called once per frame
	void Update () {
		coins = coin.GetComponent<Score>().coins;
	}

	public void FirstButton()
	{
		if(FirstUnlocked == true || coins >= FirstLevelSkins)
		{
			
			if(FirstUnlocked == false)
			{
				coin.coins -= FirstLevelSkins;
				coin.UpdateCoins();
				FirstUnlocked = true;
				anim.runtimeAnimatorController = Skin1;
				Button1.SetActive(false);
				//image1.GetComponent<Image>().sprite = ButtonSkin1;
				LastSkin = 1;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(1);
				}


				stats.Save();
				
			}
			else
			{
				anim.runtimeAnimatorController = Skin1;
				LastSkin = 1;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(1);
				}


				stats.Save();
			}
		}
		
	}

	public void SecondButton()
	{
		if (SecondUnlocked == true || coins >= FirstLevelSkins)
		{
			if (SecondUnlocked == false)
			{
				coin.coins -= FirstLevelSkins;
				coin.UpdateCoins();
				SecondUnlocked = true;
				anim.runtimeAnimatorController = Skin2;
				Button2.SetActive(false);
				//image2.GetComponent<Image>().sprite = ButtonSkin2;
				LastSkin = 2;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(2);
				}

				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin2;
				LastSkin = 2;


				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(2);
				}


				stats.Save();
			}
		}
	}

	public void ThirdButton()
	{
		if (ThirdUnlocked == true || coins >= FirstLevelSkins)
		{
			if (ThirdUnlocked == false)
			{
				coin.coins -= FirstLevelSkins;
				coin.UpdateCoins();
				ThirdUnlocked = true;
				anim.runtimeAnimatorController = Skin3;
				Button3.SetActive(false);
				//image3.GetComponent<Image>().sprite = ButtonSkin3;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(3);
				}

				LastSkin = 3;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin3;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(3);
				}

				LastSkin = 3;
				stats.Save();
			}
		}
	}

	public void FourthButton()
	{
		if (FourthUnlocked == true || coins >= SecondLevelSkins)
		{
			if (FourthUnlocked == false)
			{
				coin.coins -= SecondLevelSkins;
				coin.UpdateCoins();
				FourthUnlocked = true;
				anim.runtimeAnimatorController = Skin4;
				Button4	.SetActive(false);
				//image4.GetComponent<Image>().sprite = ButtonSkin4;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(4);
				}

				LastSkin = 4;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin4;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(4);
				}

				LastSkin = 4;
				stats.Save();
			}
		}
	}

	public void FifthButton()
	{
		if (FifthUnlocked == true || coins >= SecondLevelSkins)
		{
			if (FifthUnlocked == false)
			{
				coin.coins -= SecondLevelSkins;
				coin.UpdateCoins();
				FifthUnlocked = true;
				anim.runtimeAnimatorController = Skin5;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(5);
				}

				Button5.SetActive(false);
				//image5.GetComponent<Image>().sprite = ButtonSkin5;

				

				LastSkin = 5;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin5;
				LastSkin = 5;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(5);
				}

				stats.Save();
			}
		}
	}

	public void SixthButton()
	{
		if (SixthUnlocked == true || coins >= SecondLevelSkins)
		{
			if (SixthUnlocked == false)
			{
				coin.coins -= SecondLevelSkins;
				coin.UpdateCoins();
				SixthUnlocked = true;
				anim.runtimeAnimatorController = Skin6;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(6);
				}

				//image6.GetComponent<Image>().sprite = ButtonSkin6;
				Button6.SetActive(false);
				LastSkin = 6;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin6;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(6);
				}

				LastSkin = 6;
				stats.Save();
			}
		}
	}

	public void SeventhButton()
	{
		if (SeventhUnlocked == true || coins >= ThirdLevelSkins)
		{
			if (SeventhUnlocked == false)
			{
				coin.coins -= ThirdLevelSkins;
				coin.UpdateCoins();
				SeventhUnlocked = true;
				anim.runtimeAnimatorController = Skin7;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(7);
				}

				//image7.GetComponent<Image>().sprite = ButtonSkin7;
				Button7.SetActive(false);
				LastSkin = 7;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin7;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(7);
				}

				LastSkin = 7;
				stats.Save();
			}
		}
	}

	public void EigthButton()
	{
		if (EightUnlocked == true || coins >= ThirdLevelSkins)
		{
			if (EightUnlocked == false)
			{
				coin.coins -= ThirdLevelSkins;
				coin.UpdateCoins();
				EightUnlocked = true;
				Button8.SetActive(false);
				anim.runtimeAnimatorController = Skin8;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(8);
				}

				//image8.GetComponent<Image>().sprite = ButtonSkin8;
				LastSkin = 8;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin8;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(8);
				}

				LastSkin = 8;
				stats.Save();
			}
		}
	}

	public void NinthButton()
	{
		if (NinthUnlocked == true || coins >= ThirdLevelSkins)
		{
			if (NinthUnlocked == false)
			{
				coin.coins -= ThirdLevelSkins;
				coin.UpdateCoins();
				NinthUnlocked = true;
				Button9.SetActive(false);
				anim.runtimeAnimatorController = Skin9;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(9);
				}

				//image9.GetComponent<Image>().sprite = ButtonSkin9;
				LastSkin = 9;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin9;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(9);
				}

				LastSkin = 9;
				stats.Save();
			}
		}
	}

	public void TenthButton()
	{
		if (TenthUnlocked == true || coins >= FourthLevelSkins)
		{
			if (TenthUnlocked == false)
			{
				coin.coins -= FourthLevelSkins;
				coin.UpdateCoins();
				TenthUnlocked = true;
				Button10.SetActive(false);
				anim.runtimeAnimatorController = Skin10;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(10);
				}

				//image10.GetComponent<Image>().sprite = ButtonSkin10;
				LastSkin = 10;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin10;
				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(10);
				}
				LastSkin = 10;
				stats.Save();
			}
		}
	}

	public void EleventhButton()
	{
		if (EleventhUnlocked == true || coins >= FourthLevelSkins)
		{
			if (EleventhUnlocked == false)
			{
				coin.coins -= FourthLevelSkins;
				coin.UpdateCoins();
				EleventhUnlocked = true;
				Button11.SetActive(false);
				anim.runtimeAnimatorController = Skin11;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(11);
				}

				LastSkin = 11;
				stats.Save();
				//image11.GetComponent<Image>().sprite = ButtonSkin11;
			}
			else
			{
				anim.runtimeAnimatorController = Skin11;
				LastSkin = 11;

                foreach (TutorialCube cube in tutorialCube)
                {
                    cube.GetComponent<TutorialCube>().ChangeSprite(11);
                }

                stats.Save();
			}
		}
	}

	public void TwelthButton()
	{
		if (TwelthUnlocked == true || coins >= FourthLevelSkins)
		{
			if (TwelthUnlocked == false)
			{
				coin.coins -= FourthLevelSkins;
				coin.UpdateCoins();
				TwelthUnlocked = true;
				Button12.SetActive(false);
				anim.runtimeAnimatorController = Skin12;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(12);
				}


				//image12.GetComponent<Image>().sprite = ButtonSkin12;
				LastSkin = 12;
				stats.Save();
			}
			else
			{
				anim.runtimeAnimatorController = Skin12;
				LastSkin = 12;

				foreach (TutorialCube cube in tutorialCube)
				{
					cube.GetComponent<TutorialCube>().ChangeSprite(12);
				}

				stats.Save();
			}
		}
	}

	public void NormalSkinColor()
	{
		anim.runtimeAnimatorController = DefaultSkin;


		foreach (TutorialCube cube in tutorialCube)
		{
			cube.GetComponent<TutorialCube>().ChangeSprite(0);
		}

		LastSkin = 0;
		stats.Save();

	}

	public void ResetProgress()
	{

		NormalSkinColor();

		image1.GetComponent<Image>().sprite = ButtonSkin1;
		image2.GetComponent<Image>().sprite = ButtonSkin2;
		image3.GetComponent<Image>().sprite = ButtonSkin3;
		image4.GetComponent<Image>().sprite = ButtonSkin4;
		image5.GetComponent<Image>().sprite = ButtonSkin5;
		image6.GetComponent<Image>().sprite = ButtonSkin6;
		image7.GetComponent<Image>().sprite = ButtonSkin7;
		image8.GetComponent<Image>().sprite = ButtonSkin8;
		image9.GetComponent<Image>().sprite = ButtonSkin9;
		image10.GetComponent<Image>().sprite = ButtonSkin10;
		image11.GetComponent<Image>().sprite = ButtonSkin11;
		image12.GetComponent<Image>().sprite = ButtonSkin12;


		Button1.SetActive(true);
		Button2.SetActive(true);
		Button3.SetActive(true);
		Button4.SetActive(true);
		Button5.SetActive(true);
		Button6.SetActive(true);
		Button7.SetActive(true);
		Button8.SetActive(true);
		Button9.SetActive(true);
		Button10.SetActive(true);
		Button11.SetActive(true);
		Button12.SetActive(true);

		FirstUnlocked = false;
		SecondUnlocked = false;
		ThirdUnlocked = false;	
		FourthUnlocked = false;
		FifthUnlocked = false;
		SixthUnlocked = false;
		SeventhUnlocked = false;
		EightUnlocked = false;
		NinthUnlocked = false;
		TenthUnlocked = false;
		EleventhUnlocked = false;
		TwelthUnlocked = false;

	}

}
