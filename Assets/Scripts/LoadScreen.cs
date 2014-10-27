using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {
	private Player player;

	// Use this for initialization
	void Start () {
		name = GUI.TextField(new Rect(40, yaxis, 100, 20), name, 25);
		GUI.Label(new Rect(50, i*20, 100, 20), name);
	}

	void addOnGUI(string name, int yaxis){
		
		name = GUI.TextField(new Rect(40, yaxis, 100, 20), name, 25);
	}



	
	// Update is called once per frame
	void Update () {
		//switch to game
		if(Input.GetKeyDown(KeyCode.G)){
			Application.LoadLevel(1);
		}

		//switch to menu
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}
	}
}
