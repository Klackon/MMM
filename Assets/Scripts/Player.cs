using UnityEngine;
using System.Collections;

public class Player {

	// all fields, can add or get rid of 
	private string name;
	private string race;
	private string wizard;
	private string portrait;
	private int spellRank;
	private string spellPick;
	private string specialAbility;
	private int banner;
	private string homeCityName;
	// constructor

	public Player(string name){
		this.name = name;
	}

	public string getName(){
		return name;
	}

	// since creatingi character is step-by-step
	// will probably call method to instantiate the fields

	public void selectRace(string race){
		this.race = race;
	}

	public void selectWizard(string wizard){
		this.wizard = wizard;
	}

	public void selectBanner(int banner){
		this.banner = banner;
	}

	public void selectSpecialAbility(string specialAbility){
		this.specialAbility = specialAbility;
	}

	public void selectCityName(string homeCityName){
		this.homeCityName = homeCityName;
	}






	// not all field requires getters

	public string getRace(){
		return race;
	}

	public string getWizard(){
		return wizard;
	}

	// need to save all fields of a player
	// if we decide to implement saving  the game
	// as one of our features



	// other methods

	// set spellRank with returned value
	public void setSpellRank(int toSet){
		spellRank = toSet;
	}

	public int getSpellRank(){
		return spellRank;
	}








}
