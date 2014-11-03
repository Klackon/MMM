using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {
	public string name = "name";

	string stringToEdit;
	string label;
	// Use this for initialization
	void Start () {

	}
	void OnGUI() {


		stringToEdit = GUI.TextField (new Rect (160, 0, 100, 20), stringToEdit, 25);
		GUI.Label(new Rect(60, 0, 100, 20), label);
			//stringToEdit[i] = GUILayout.TextField(stringToEdit[i], 5, GUILayout.Width(100));
	}
	
	void addOnGUI(string name, int yaxis){
		
		name = GUI.TextField(new Rect(40, yaxis, 100, 20), name, 25);
	}
	// Update is called once per frame
	void Update () {
		// save fields
		if(Input.GetKeyDown(KeyCode.Return)){
			name = stringToEdit.ToString();
			/*
			Player player1 = new Player(name);
			player1.load();
			*/
		}
		
		// switch to game
		if(Input.GetKeyDown(KeyCode.F1)){
		
			name = stringToEdit.ToString();
			Player player = new Player(name);
			//player.load (); // fix this
			Debug.Log (name);
			Application.LoadLevel(1);
		}

		// switch to menu
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}
		
	}
	
	void Awake(){
		Input.eatKeyPressOnTextFieldFocus = false;
		//stringToEdit = new string[1];
		//label = new string[1];

		stringToEdit = string.Empty;
		label = string.Empty;
		
		label = "Name";
	}

}
