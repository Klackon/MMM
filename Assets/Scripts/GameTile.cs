﻿using UnityEngine;
using System.Collections;

public class GameTile{
	public bool visited;
	public enum TerrainType{Desert, Forest, Grasslands, Hills, Mountain, Ocean, River, Shores, Swamp, Tundra};
	public TerrainType terrain;
	public enum SpecialTerrain{ChaosNodes, NatureNodes, Ore, Ruins, Temples, SorceryNodes, TowerOfWizadry, UndergroundLair, Crystal, None};
	public SpecialTerrain altTerrain;
	public enum StructureType{Road, Cities, Hamlets, Settlements, None};
	public StructureType structure; 
	public bool hasStructure;
	public bool hasSpecial;
	public bool hasUnit;
	public bool hasMonster;
	public bool occupied;
	public bool onScreen;
	public bool revealed;
	//public Vector2 position;
	public Vector3 position;
	public float movementVal;
	public float buildVal;
	public float foodProduction;
	public float goldProduction;
	public float manaProduction;
	public float production;
	public float maxPopulation;
	public GameObject square;
	public GameTile[,] board;
	//public int[,] index;
	public Location index;
	public GameTile linkedTiles;

	public string Arcanus = "Texture/terrain/arcanus/";
	public string Myrror = "Texture/terrain/myrror/";

	public GameTile(){
		//position = Vector2.zero;
		//position = new Vector2(5,-5);
		position = new Vector3(5, -5, -10);
		//position for first cube
			// every subsequent square on this row is +10,0
			// every subsequent row is 0, -10
		movementVal = 1;
		buildVal = 1;
		foodProduction = 1;
		goldProduction = 1;
		manaProduction = 1;
		maxPopulation = 1;
		//terrain = TerrainType.Desert;
		/*
		switch(Random.Range(0,10)){
		case 0: 
			terrain = TerrainType.Desert;
			break;
		case 1: 
			terrain = TerrainType.Forest;
			break;
		case 2: 
			terrain = TerrainType.Grasslands;
			break;
		case 3:
			terrain = TerrainType.Hills;
			break;
		case 4:
			terrain = TerrainType.Mountain;
			break;
		case 5:
			terrain = TerrainType.Ocean;
			break;
		case 6:
			terrain = TerrainType.River;
			break;
		case 7:
			terrain = TerrainType.Shores;
			break;
		case 8:
			terrain = TerrainType.Swamp;
			break;
		case 9:
			terrain = TerrainType.Tundra;
			break;
		}
		*/
		square = createTile();
		terrain = this.randomizeTerrain();
		this.setTerrain(terrain);
		altTerrain = SpecialTerrain.None;
		structure = StructureType.None;
		hasSpecial = false;
		hasStructure = false;
		hasUnit = false;
		hasMonster = false;
		occupied = false;
		onScreen = false;
		revealed = false;
	}

	//public GameTile(Vector2 position){
	public GameTile(Vector3 position){
		this.position = position;
		/*
		movementVal = 1;
		buildVal = 1;
		foodProduction = 1;
		goldProduction = 1;
		manaProduction = 1;
		production = 1;
		maxPopulation = 1;
		terrain = TerrainType.Desert;
		*/
		square = createTile();
		terrain = this.randomizeTerrain();
		this.setTerrain(terrain);
		altTerrain = this.randomizeAltTerrain();
		//altTerrain = SpecialTerrain.None;
		structure = StructureType.None;
		hasSpecial = false;
		hasStructure = false;
		hasUnit = false;
		hasMonster = false;
		occupied = false;
		onScreen = false;
		revealed = false;
	}

	// Adds the physical representation of the game tile
	public GameObject createTile(){
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = this.position;
		cube.transform.localScale = new Vector3(10,10,1);
		// needs to add a sprite renderer with the correct sprite
		return cube;
	}

	public TerrainType randomizeTerrain(){
		switch(Random.Range(0,10)){
		case 0: 
			terrain = TerrainType.Desert;
			break;
		case 1: 
			terrain = TerrainType.Forest;
			break;
		case 2: 
			terrain = TerrainType.Grasslands;
			break;
		case 3:
			terrain = TerrainType.Hills;
			break;
		case 4:
			terrain = TerrainType.Mountain;
			break;
		case 5:
			terrain = TerrainType.Ocean;
			break;
		case 6:
			terrain = TerrainType.River;
			break;
		case 7:
			terrain = TerrainType.Shores;
			break;
		case 8:
			terrain = TerrainType.Swamp;
			break;
		case 9:
			terrain = TerrainType.Tundra;
			break;
		}
		return terrain;
	}

	public SpecialTerrain randomizeAltTerrain(){
		switch(Random.Range(0,10)){
		case 0: 
			altTerrain = SpecialTerrain.ChaosNodes;
			break;
		case 1: 
			altTerrain = SpecialTerrain.Crystal;
			break;
		case 2: 
			altTerrain = SpecialTerrain.NatureNodes;
			break;
		case 3:
			altTerrain = SpecialTerrain.None;
			break;
		case 4:
			altTerrain = SpecialTerrain.Ore;
			break;
		case 5:
			altTerrain = SpecialTerrain.Ruins;
			break;
		case 6:
			altTerrain = SpecialTerrain.SorceryNodes;
			break;
		case 7:
			altTerrain = SpecialTerrain.Temples;
			break;
		case 8:
			altTerrain = SpecialTerrain.TowerOfWizadry;
			break;
		case 9:
			altTerrain = SpecialTerrain.UndergroundLair;
			break;
		}
		return altTerrain;
	}

	public void setTerrain(TerrainType val){
		//Debug.Log("setting terrain");
		switch(val){
		case TerrainType.Desert:
			movementVal = 2;
			//buildVal = 1;
			foodProduction = 0;
			goldProduction = 0;

			production = 0.1f;
			//manaProduction = 1;
			maxPopulation = 1;
			//terrain = TerrainType.Desert;
			Texture desert = (Texture)Resources.Load(Arcanus+"desert/1", typeof(Texture)); 
			square.renderer.material.mainTexture = desert;
			// set sprite for renderer (or in game manager)
			break;
		case TerrainType.Forest:
			movementVal = 2;
			//buildVal = 1;
			foodProduction = 0.5f;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0.05f;
			//maxPopulation = 1;
			//terrain = TerrainType.Forest;
			Texture forest = (Texture)Resources.Load(Arcanus+"hills/1", typeof(Texture)); 
			square.renderer.material.mainTexture = forest;
			break;
		case TerrainType.Grasslands:
			movementVal = 1;
			//buildVal = 1;
			foodProduction = 1.5f;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.Grasslands;
			Texture grasslands = (Texture)Resources.Load(Arcanus+"grasslands/1", typeof(Texture)); 
			square.renderer.material.mainTexture = grasslands;
			break;
		case TerrainType.Hills:
			movementVal = 2;
			//buildVal = 1;
			foodProduction = 0.5f;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0.05f;
			//maxPopulation = 1;
			//terrain = TerrainType.Hills;
			Texture hills = (Texture)Resources.Load(Myrror+"hills/1", typeof(Texture)); 
			square.renderer.material.mainTexture = hills;
			break;
		case TerrainType.Mountain:
			movementVal = 3;
			//buildVal = 1;
			foodProduction = 0;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0.1f;
			//maxPopulation = 1;
			//terrain = TerrainType.Mountain;
			Texture mountain = (Texture)Resources.Load(Arcanus+"mountains/1", typeof(Texture)); 
			square.renderer.material.mainTexture = mountain;
			break;
		case  TerrainType.Ocean:
			movementVal = 1;
			//buildVal = 1;
			foodProduction = 0.5f;
			goldProduction = 0.1f;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.Ocean;
			Texture ocean = (Texture)Resources.Load(Arcanus+"ocean/1", typeof(Texture)); 
			square.renderer.material.mainTexture = ocean;
			break;
		case TerrainType.River:
			movementVal = 2;
			//buildVal = 1;
			foodProduction = 2;
			goldProduction = 0.2f;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.River;
			Texture river = (Texture)Resources.Load(Arcanus+"river/1", typeof(Texture)); 
			square.renderer.material.mainTexture = river;
			break;
		case TerrainType.Shores:
			movementVal = 1;
			//buildVal = 1;
			foodProduction = 0;
			goldProduction = 0.1f;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.Shores;
			Texture shore = (Texture)Resources.Load(Arcanus+"shore/1", typeof(Texture)); 
			square.renderer.material.mainTexture = shore;
			break;
		case TerrainType.Swamp:
			movementVal = 3;
			//buildVal = 1;
			foodProduction = 0.5f;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.Swamp;
			Texture swamp = (Texture)Resources.Load(Arcanus+"swamp/1", typeof(Texture)); 
			square.renderer.material.mainTexture = swamp;
			break;
		case TerrainType.Tundra:
			movementVal = 2;
			//buildVal = 1;
			foodProduction = 0;
			goldProduction = 0;
			//manaProduction = 1;
			production = 0;
			//maxPopulation = 1;
			//terrain = TerrainType.Tundra;
			Texture tundra = (Texture)Resources.Load(Arcanus+"tundra/1", typeof(Texture)); 
			square.renderer.material.mainTexture = tundra;
			break;
		}
	}

	/*
	public void setOnScreen(bool val){
		onScreen = val;
	}
	public bool getOnScreen(){
		return onScreen;
	}

	public void setRevealed(bool val){
		revealed = val;
	}
	public bool getRevealed(){
		return revealed;
	}
	*/

	public bool hasFog(){
		if(onScreen&&revealed){
			return false;
		} else if(onScreen&&!revealed){
			return true;
		} else {
			return true;
		}
	}

	public void setBoard(GameTile[,] bo){
		board = bo;
	}

	public void setLocation(int i, int j){
		index = new Location(i, j);
	}
	public Location getLocation(){
		return index;
	}
	public Vector3 getPosition(){
		return position;
	}

	public void createStructure(){

	}

	public void setRevealed(bool val){
		revealed = val;
		// DO some sprite shit to change whether or not fog appears
	}

	public Vector3 moveToTile(GameObject go){
		Debug.Log("attempting move");
		go.transform.position = this.position;
		return go.transform.position;
	}

	/*
	public Vector3 moveToTile(GameObject go){
		Debug.Log("attempting move");
		go.transform.position = this.position;
		return go.transform.position;
	}
	*/
	/*
	public Vector3 moveToTile(GameObject go, int[] location){
		Debug.Log("attempting move");
		GameTile tile = board[location[0],location[1]];
		//go.transform.position = this.position;
		//return go.transform.position;
		return tile.moveToTile(go);
	}
	*/
}
