using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	public bool FadeImage = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (FadeImage == true)
		{
			if (GetComponent<Image>().color.a <= 1)
			{
				GetComponent<Image>().color += new Color(0, 0, 0, 0.6f * Time.deltaTime);

			}
			if (GetComponent<Image>().color.a >= 1)
			{
				Invoke("RestartGame", 0.5f);
			}
		}
		else if (FadeImage == false)
		{
			if (GetComponent<Image>().color.a >= 0.01f)
			{
				GetComponent<Image>().color -= new Color(0, 0, 0, 0.4f * Time.deltaTime);
			}
		}
	}


		void RestartGame()
		{
			Application.LoadLevel(Application.loadedLevel);
		}
}
	



	

