﻿using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}

		if(Input.GetKeyDown(KeyCode.L)){
			Application.LoadLevel(5);
		}
	}
}
