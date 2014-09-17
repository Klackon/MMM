using UnityEngine;
using System.Collections;

public class CharCreateScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// switch to game
		if(Input.GetKeyDown(KeyCode.G)){
			Application.LoadLevel(1);
		}

		// switch to menu
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}
	}
}
