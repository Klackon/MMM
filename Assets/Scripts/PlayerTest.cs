using UnityEngine;
using System.Collections;

public class PlayerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Player player1 = new Player ("Daniel Kuo");
		player1.selectRace ("human");
		player1.selectWizard ("Wizard1");
		player1.selectBanner (1);
		player1.selectSpecialAbility ("Invinsible");
		player1.intializeSpellRank ();
		player1.setSpellRank (10);
		player1.selectCityName ("Atlanta");
		Debug.Log(player1.getRace());
		Debug.Log(player1.getName());
		Debug.Log (player1.getWizard());
		Debug.Log (player1.getSpellRank ());

	}
	
	// Update is called once per frame
	void Update () {

	}
}
