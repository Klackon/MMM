using UnityEngine;
using System.Collections;

public class CharCreateScreen : MonoBehaviour {
	public string name = "name";
	public string race = "race";
	public string wizard = "Select wizard";
	public string portrait = "Select Portrait";
	public string spellRank = "spellRank";
	public string spellPick = "spellPick";
	public string specialAbility = "speicalAbility";
	public string banner = "banner";
	public string homeCityName = "homeCityName";
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI() {
		addOnGUI (name, 20);
		addOnGUI (race, 40);
		addOnGUI (wizard, 60);
		addOnGUI (portrait, 80);
		addOnGUI (spellRank, 100);
		addOnGUI (spellPick, 120);
		addOnGUI (specialAbility, 140);
		addOnGUI (banner, 160);
		addOnGUI (homeCityName, 180);
	}

	void addOnGUI(string name, int yaxis){
		name = GUI.TextField(new Rect(60, yaxis, 100, 20), name, 25);
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
