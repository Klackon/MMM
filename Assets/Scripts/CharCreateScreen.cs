using UnityEngine;
using System.Collections;

public class CharCreateScreen : MonoBehaviour {
	public string name = "name";
	public string race = "race";
	public string wizard = "Select wizard";
	public string portrait = "Select Portrait";
	public string spellPick = "spellPick";
	public string specialAbility = "speicalAbility";
	public string banner = "banner";
	public string homeCityName = "homeCityName";
	string[] stringToEdit;
	string[] label;
	// Use this for initialization
	void Start () {

	}
	void OnGUI() {
		/*addOnGUI (name, 20);
		addOnGUI (race, 40);
		addOnGUI (wizard, 60);
		addOnGUI (portrait, 80);
		addOnGUI (spellPick, 120);
		addOnGUI (specialAbility, 140);
		addOnGUI (banner, 160);
		addOnGUI (homeCityName, 180);*/
		for (int i = 0; i < stringToEdit.Length; ++i) {
						stringToEdit [i] = GUI.TextField (new Rect (150, i * 20, 100, 20), stringToEdit [i], 25);
						GUI.Label(new Rect(50, i*20, 100, 20), label[i]);
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
		}

		// switch to game
		if(Input.GetKeyDown(KeyCode.G)){
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
		label [0] = "name";
		label [1]= "race";
		label [2]= "Select wizard";
		label [3] = "Select Portrait";
		label [4] = "spellPick";
		label [5] = "speicalAbility";
		label [6] = "banner";
		label [7] = "homeCityName";
	}
}
