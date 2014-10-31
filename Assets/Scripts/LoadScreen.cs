using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {
	public string name = "name";

	string[] stringToEdit;
	string[] label;
	// Use this for initialization
	void Start () {

	}
	void OnGUI() {

		for (int i = 0; i < 1; ++i) {
			stringToEdit [i] = GUI.TextField (new Rect (160, i * 20, 100, 20), stringToEdit [i], 25);
			GUI.Label(new Rect(60, i*20, 100, 20), label[i]);
			//stringToEdit[i] = GUILayout.TextField(stringToEdit[i], 5, GUILayout.Width(100));
		}

	}
	
	void addOnGUI(string name, int yaxis){
		
		name = GUI.TextField(new Rect(40, yaxis, 100, 20), name, 25);
	}
	// Update is called once per frame
	void Update () {
		// save fields
		if(Input.GetKeyDown(KeyCode.Return)){
			name = stringToEdit[0].ToString();
			/*
			Player player1 = new Player(name);
			player1.load();
			*/
		}
		
		// switch to game
		if(Input.GetKeyDown(KeyCode.F1)){
			/*
			name = stringToEdit[0].ToString();
			race = stringToEdit[1].ToString();
			wizard = stringToEdit[2].ToString();
			portrait = stringToEdit[3].ToString();
			spellPick = stringToEdit[4].ToString();
			specialAbility = stringToEdit[5].ToString();
			banner = stringToEdit[6].ToString();
			homeCityName = stringToEdit[7].ToString();
			print (homeCityName);
			Player player1 = new Player(name,race,wizard,portrait,spellPick,specialAbility,banner,homeCityName);
			player1.save();
			*/

			name = stringToEdit[0].ToString();
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
		stringToEdit = new string[8];
		label = new string[8];
		for (int i = 0; i < stringToEdit.Length; ++i) {
			stringToEdit [i] = string.Empty;
			label [i] = string.Empty;
		}
		label [0] = "Name";
	
		
	}

}
