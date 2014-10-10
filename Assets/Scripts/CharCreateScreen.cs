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
		for (int i = 0; i < stringToEdit.Length; ++i)
			stringToEdit[i] = GUI.TextField(new Rect(120, i*20, 100, 20),stringToEdit[i] , 25);
		GUI.Label (new Rect (35, 0, 100, 20), "Name");
		GUI.Label (new Rect (35, 20, 100, 20), "Race");
		GUI.Label (new Rect (35, 40, 100, 20), "Wizard");
		GUI.Label (new Rect (35, 60, 100, 20), "Portrait");
		GUI.Label (new Rect (35, 80, 100, 20), "Spell Pick");
		GUI.Label (new Rect (35, 100, 100, 20), "Special Ability");
		GUI.Label (new Rect (35, 120, 100, 20), "Banner");
		GUI.Label (new Rect (35, 140, 100, 20), "Home City");
			//stringToEdit[i] = GUILayout.TextField(stringToEdit[i], 5, GUILayout.Width(100));
	}

	void addOnGUI(string name, int yaxis){

		name = GUI.TextField(new Rect(60, yaxis, 100, 20), name, 25);
		}
	// Update is called once per frame
	void Update () {
		// switch to game
		if(Input.GetKeyDown(KeyCode.G)){
			Application.LoadLevel(1);
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
		}

		// switch to menu
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}
	    
	}

	void Awake(){
		Input.eatKeyPressOnTextFieldFocus = false;
		stringToEdit = new string[8];
		for (int i = 0; i < stringToEdit.Length; ++i)
			stringToEdit[i] = string.Empty;
	}
}
