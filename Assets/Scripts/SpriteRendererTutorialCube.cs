using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererTutorialCube : MonoBehaviour {

	// Use this for initialization
	
	public void ActivateSpriterenderer()
	{
		GetComponent<SpriteRenderer>().enabled = true;
		
	}
}
