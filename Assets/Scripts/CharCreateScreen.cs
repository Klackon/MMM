using UnityEngine;
using System.Collections;

public class CharCreateScreen : MonoBehaviour {
	public string name = "name";
	public string race = "race";
	public string wizard = "Select wizard";
	public string portrait = "1";
	public string spellPick = "spellPick";
	public string specialAbility = "speicalAbility";
	public string banner = "banner";
	public string homeCityName = "homeCityName";
	public int wizardNum = 1;
	public Texture WizardPic;
	public string texturePath;
	string[] stringToEdit;
	string[] label;
	// Use this for initialization
	void Start () {
		string texturePath = "wizards/WZ01";
		//Texture2D tex = new Texture2D(100, 100);
		WizardPic = (Texture)Resources.Load(texturePath, typeof(Texture)); 
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
						stringToEdit [i] = GUI.TextField (new Rect (160, i * 20, 100, 20), stringToEdit [i], 25);
						GUI.Label(new Rect(60, i*20, 100, 20), label[i]);
						//stringToEdit[i] = GUILayout.TextField(stringToEdit[i], 5, GUILayout.Width(100));
				}
		GUI.DrawTexture(new Rect(320, 0, 100, 100), WizardPic, ScaleMode.StretchToFill, true, 10.0F);
		if (GUI.Button (new Rect (320, 100, 50, 20), "Last")) {
				if(wizardNum==1){
					wizardNum = 14;
				}
				else{
					wizardNum--;
				}
			WizardPic = (Texture)Resources.Load("wizards/WZ"+wizardNum.ToString(), typeof(Texture)); 
			GUI.DrawTexture(new Rect(320, 0, 100, 100), WizardPic, ScaleMode.StretchToFill, true, 10.0F);
			}
		if (GUI.Button (new Rect (370, 100, 50, 20), "Next")) {
			if(wizardNum==14){
				wizardNum = 1;
			}
			else{
				wizardNum++;
			}
				}
			WizardPic = (Texture)Resources.Load("wizards/WZ"+wizardNum.ToString(), typeof(Texture)); 
			GUI.DrawTexture(new Rect(320, 0, 100, 100), WizardPic, ScaleMode.StretchToFill, true, 10.0F);
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
			portrait = wizardNum.ToString();
			spellPick = stringToEdit[3].ToString();
			specialAbility = stringToEdit[4].ToString();
			banner = stringToEdit[5].ToString();
			homeCityName = stringToEdit[6].ToString();
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
		label [0] = "Name";
		label [1]= "Race";
		label [2]= "Select wizard";
<<<<<<< HEAD
		label [3] = "Select Portrait";
		label [4] = "SpellPick";
		label [5] = "SpeicalAbility";
		label [6] = "Banner";
		label [7] = "HomeCityName";
=======
		//label [3] = "Select Portrait";
		label [3] = "spellPick";
		label [4] = "speicalAbility";
		label [5] = "banner";
		label [6] = "homeCityName";
>>>>>>> FETCH_HEAD
	}
}
