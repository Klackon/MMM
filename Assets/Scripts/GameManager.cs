using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private ImmediateStateMachine stateMachine = new ImmediateStateMachine ();
	int n;
	GameObject player;
	PlayerManager playerScript;
	GameObject[] enemy;
	EnemyManager enemyScript;

	// Use this for initialization
	void Start () {
		n = 0;
		switchToGameFSM();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		n++;
		Debug.Log (n);
		if(Input.GetKeyDown(KeyCode.C)){
			Debug.Log("test");
		}

		if(Input.GetKey(KeyCode.D)){
			Debug.Log ("D?");
		}
		*/

		/*
		if(Input.GetKeyDown(KeyCode.O)){
			Application.Load
		}
		*/

		stateMachine.Execute();
	}

	//////////////////////////////////////////////////////////////////////
	// GAME STATES
	//////////////////////////////////////////////////////////////////////

	/*
	// Menu State	
	public void switchToMenuFSM() {
		stateMachine.ChangeState (enterMENU, updateMENU, exitMENU);
	}
	
	void enterMENU() {
		Application.LoadLevel(0);
		Debug.Log("ENTER MENU");
	}

	void updateMENU() {
		Debug.Log("MENU UPDATE");

		if(Input.GetKeyDown(KeyCode.C)){
			switchToCharCreateFSM();
		}

		if(Input.GetKeyDown(KeyCode.L)){
			switchToLoadFSM();
		}
	}

	void exitMENU () {

	}

	// Character Creation State	
	public void switchToCharCreateFSM() {
		stateMachine.ChangeState (enterCHARCREATE, updateCHARCREATE, exitCHARCREATE);
	}
	
	void enterCHARCREATE() {
		Application.LoadLevel(2);
		Debug.Log("ENTER CHAR CREATE");
	}
	void updateCHARCREATE() {
		if(Input.GetKeyDown(KeyCode.G)){
			switchToGameFSM();
		}

		if(Input.GetKeyDown(KeyCode.M)){
			switchToMenuFSM();
		}
	}
	void exitCHARCREATE () {
		
	}

	// Load State	
	public void switchToLoadFSM() {
		stateMachine.ChangeState (enterLOAD, updateLOAD, exitLOAD);
	}
	
	void enterLOAD() {
		Application.LoadLevel(5);
		Debug.Log("ENTER LOAD");
	}
	void updateLOAD() {
		if(Input.GetKeyDown(KeyCode.M)){
			switchToMenuFSM();
		}

		if(Input.GetKeyDown(KeyCode.G)){
			switchToGameFSM();
		}
	}
	void exitLOAD () {
		
	}
	*/

	// Main Game State	
	public void switchToGameFSM() {
		stateMachine.ChangeState (enterGAME, updateGAME, exitGAME);
	}
	
	void enterGAME() {
		//Application.LoadLevel(1);
		Debug.Log("ENTER GAME");
		
		// Load the character\
		player = GameObject.FindGameObjectWithTag("Player");
		if(player != null){
			playerScript = player.GetComponent<PlayerManager>();
		}
		enemy = GameObject.FindGameObjectsWithTag("Enemy");
	}
	void updateGAME() {

		if(Input.GetKeyDown(KeyCode.Return)){
			switchToPlayerTurnFSM();
		}

		if(Input.GetKeyDown(KeyCode.O)){
			//switchToOverFSM();
			Application.LoadLevel(3);
		}
	}
	void exitGAME () {
		Debug.Log ("EXIT GAME");
	}

	// Pause State	
	public void switchToPauseFSM() {
		stateMachine.ChangeState (enterPAUSE, updatePAUSE, exitPAUSE);
	}
	
	void enterPAUSE() {
		//Application.LoadLevel(3);
		// make pausing stay in game scene
		Debug.Log("ENTER PAUSE");
	}
	void updatePAUSE() {
		if(Input.GetKeyDown(KeyCode.G)){
			switchToGameFSM();
		}
		Debug.Log("GAME IS PAUSED");
		if(Input.GetKeyDown(KeyCode.M)){
			//switchToMenuFSM();
			Application.LoadLevel(0);
		}
	}
	void exitPAUSE () {
		Debug.Log("EXIT PAUSE");
	}

	public void switchToPlayerTurnFSM() {
		stateMachine.ChangeState(enterPLAYERTURN, updatePLAYERTURN, exitPLAYERTURN);
	}
	
	void enterPLAYERTURN(){
		if(player == null){ 
			Debug.Log ("ERROR: PLAYER NOT FOUND");
			switchToGameFSM();
		}
		if(enemy == null){
			Debug.Log("ERROR: NO ENEMIES FOUND");
			switchToGameFSM();
		}
	}
	
	void updatePLAYERTURN(){
		if(Input.GetKeyDown(KeyCode.P)) switchToPauseFSM();
		if(Input.GetKeyDown(KeyCode.Escape)) Application.LoadLevel(0);
		
		//LOGIC FOR GAMEPPLAY HERE
		
		if(Input.GetKeyDown(KeyCode.Return)){
			switchToEnemyTurnFSM();
		}
	}
	
	void exitPLAYERTURN(){
		// AUTOSAVE??
	}
	
	public void switchToEnemyTurnFSM() {
		stateMachine.ChangeState(enterENEMYTURN, updateENEMYTURN, exitENEMYTURN);
	}
	
	void enterENEMYTURN(){
		
	}
	
	void updateENEMYTURN(){
		// Run through enemy logic
		if(enemy!=null){
			foreach(GameObject e in enemy){
				enemyScript = e.GetComponent<EnemyManager>();
				// enemies do enemy things
			}
		}
		
		// When complete
		switchToPlayerTurnFSM();
	}
	
	void exitENEMYTURN(){
		
	}

	/*
	// GameOver State	
	public void switchToOverFSM() {
		stateMachine.ChangeState (enterOVER, updateOVER, exitOVER);
	}
	
	void enterOVER() {
		Application.LoadLevel(4);
		Debug.Log("ENTER GAME OVER");
	}
	void updateOVER() {
		if(Input.GetKeyDown(KeyCode.M)){
			switchToMenuFSM();
		}

		if(Input.GetKeyDown(KeyCode.L)){
			switchToLoadFSM();
		}
	}
	void exitOVER () {
		
	}
	*/
}
