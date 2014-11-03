﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private ImmediateStateMachine stateMachine = new ImmediateStateMachine ();
	//GameObject[,] board;
	//public GameObject[,] coordinates;
	public GameTile[,] board;
	public int boardSize = 20;
	int spaceOffset = 10;
	int n;
	GameObject player;
	PlayerManager playerScript;
	GameObject[] enemy;
	EnemyManager enemyScript;

	// Use this for initialization
	void Start () {
		n = 0;
		float x = 5;
		float y = -5;
		float z = -10;

		board = new GameTile[boardSize, boardSize];
		//coordinates = new GameObject[boardSize, boardSize];
		/*
		for(int i = 0; i < boardSize; i++){
			for(int j = 0; j < boardSize; j++){
				coordinates[i, j] = new GameObject();
				//coordinates[i, j].AddComponent("Transform");
				coordinates[i, j].transform.position = new Vector2(i*spaceOffset,j*spaceOffset);
			}
		}
		*/
		for(int i=0; i<boardSize; i++){
			for(int j=0; j<boardSize; j++){
				//Vector2 pos = new Vector2(x, y);
				Vector3 pos = new Vector3(x, y, z);
				board[i, j] = new GameTile(pos);
				x+=10;
				if(j==boardSize-1){
					x = 5;
				}
			}
			y-=10;
		}

		/*
		foreach(GameTile gt in board){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = gt.position;
			cube.transform.localScale = new Vector3(10,10,1);
		}
		*/

		switchToGameFSM();
	}
	
	// Update is called once per frame
	void Update () {
	
		stateMachine.Execute();
	}

	//////////////////////////////////////////////////////////////////////
	// GAME STATES
	//////////////////////////////////////////////////////////////////////

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
			Debug.Log ("Player found");
		} else {
			Debug.Log ("ERROR: No Player Found");
		}
		enemy = GameObject.FindGameObjectsWithTag("Enemy");
	}
	void updateGAME() {

		//Temporary input command for testing purposes
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

		//board test
		/*
		foreach(GameObject go in coordinates){
			player.transform.position = go.transform.position;
		}
		*/
		
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
