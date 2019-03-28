using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
	public Button button;

	public GameObject Fade;

	//bool StartFading = false;

	public Fade fade;

	// Use this for initialization
	void Start() {
		
		button = GetComponent<Button>();
		fade = Fade.GetComponent<Fade>();
		button.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Fade.GetComponent<Fade>().FadeImage = true;
	}
}

