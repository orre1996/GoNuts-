using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBranch : MonoBehaviour {

	private int Branch;

	public Sprite[] TypeOfBranch;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().sprite = TypeOfBranch[Random.Range(0,5)];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
