using UnityEngine;
using System.Collections;
using System.IO;

public class Player {

	// all fields, can add or get rid of 
	private string name;
	private string race;
	private string wizard;
	private string portrait;
	private int spellRank;
	private string spellPick;
	private string specialAbility;
	private string banner;
	private string homeCityName;

	// constructors
	// depending on how we will implement the character create screen
	// we might initialize all fields all at once
	// this constructor is for loading a existing player
	public Player(string name){
		this.name = name;
	}

	public Player(string name, string race, string wizard, string spellpick, string specialAbility, string banner, string homeCityName){
		this.name = name;
		this.race = race;
		this.wizard = wizard;
		this.portrait = portrait;
		spellRank = 1;
		this.spellPick = spellPick;
		this.specialAbility = specialAbility;
		this.banner = banner;
		this.homeCityName = homeCityName;

	}

	public string getName(){
		return name;
	}

	// since creating character is step-by-step
	// will probably call method to instantiate the fields

	public void selectRace(string race){
		this.race = race;
	}

	public void selectWizard(string wizard){
		this.wizard = wizard;
	}

	public void selectBanner(string banner){
		this.banner = banner;
	}

	public void selectSpecialAbility(string specialAbility){
		this.specialAbility = specialAbility;
	}

	public void selectCityName(string homeCityName){
		this.homeCityName = homeCityName;
	}

	public void intializeSpellRank(){
		spellRank = 1;
	}





	// not all field requires getters

	public string getRace(){
		return race;
	}

	public string getWizard(){
		return wizard;
	}

	public string getPortrait(){
		return portrait;
	}

	public int getSpellRank(){
		return spellRank;
	}

	public string getSpellPick(){
		return spellPick;
	}

	public string getSpecialAbility(){
		return specialAbility;
	}

	public string getBanner(){
		return banner;
	}

	public string getCityName(){
		return homeCityName;
	}



	// need to save all fields of a player
	// if we decide to implement saving  the game
	// as one of our features


	// 
	// other methods

	// set spellRank with returned value
	public void setSpellRank(int toSet){
		spellRank = toSet;
	}


	// for saving and loading, the order is fixed
	public void save(){
		StreamWriter writetext = new StreamWriter(name + ".txt");
		// writetext.WriteLine(name); don't need this
		// when loading player, the name will be available
		writetext.WriteLine(race);
		writetext.WriteLine(wizard);
		// more writing here
		writetext.Close();
	}

	public void load(){
		string fileName = name + ".txt";
		StreamReader readtext = new StreamReader(fileName);
		race = readtext.ReadLine ();
		wizard = readtext.ReadLine ();
		// more loading here
		readtext.Close();
	}





}
