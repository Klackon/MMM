using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// switch to character create
		if(Input.GetKeyDown(KeyCode.C)){
			Application.LoadLevel(2);
		}

		// switch to load
		if(Input.GetKeyDown(KeyCode.L)){
			Application.LoadLevel(4);
		}
	}
}
