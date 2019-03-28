using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdManager : MonoBehaviour {

	public Button AdButton;

	Stats stat;
	
	public bool DoubleCoins = false;
	public bool RemoveAds = false;

	// Use this for initialization
	void Start () {
		Advertisement.Initialize("2655395", false);

		AdButton = GetComponent<Button>();
		stat = FindObjectOfType<Stats>();
		
	}

	public void TaskOnClick()
	{
		Advertisement.Initialize("2655395", false);

		if (Advertisement.IsReady())
		{
			if (RemoveAds == false)
			{
				Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
			}
			
		}
	}

	public void RandomAd()
	{
		Advertisement.Initialize("2655395", false);

		if (RemoveAds == false) {
			if (Random.value <= 0.25f)
			{
				if (Advertisement.IsReady())
				{
					Advertisement.Show("video", new ShowOptions(){ resultCallback = HandleRandomAdResult});
				}
			}
		}
	}
		
	private void HandleAdResult(ShowResult result)
	{
		switch (result)
		{
			case ShowResult.Finished:

				DoubleCoins = true;
				stat.DoubleCoinss();

				break;

			case ShowResult.Skipped:

				break;

			case ShowResult.Failed:

				break;

		}
	}

	private void HandleRandomAdResult(ShowResult result)
	{
		switch (result)
		{
			case ShowResult.Finished:

				break;

			case ShowResult.Skipped:

				break;

			case ShowResult.Failed:

				break;

		}
	}
}
