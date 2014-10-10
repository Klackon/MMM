using UnityEngine;
using System.Collections;
using System.IO;

public class PlayerManager : MonoBehaviour {

	public string name;
	public string race;
	public string wizard;
	public string portrait;
	public int spellRank;
	public string spellPick;
	public string specialAbility;
	public string banner;
	public string homeCityName;

	Player obj;

	// Use this for initialization
	void Start () {
		string fileName = "Character.txt";
		StreamReader readtext = new StreamReader(fileName);
		name = readtext.ReadLine();

		obj = new Player(name);
		obj.load();

		race = obj.getRace();
		wizard = obj.getWizard();
		portrait = obj.getPortrait();
		spellRank = obj.getSpellRank();
		spellPick = obj.getSpellPick();
		specialAbility = obj.getSpecialAbility();
		banner = obj.getBanner();
		homeCityName = obj.getCityName();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
