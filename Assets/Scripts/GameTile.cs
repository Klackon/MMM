using UnityEngine;
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
	public bool hasArmy;
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
	public float maxPopulation;

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
		terrain = TerrainType.Desert;
		altTerrain = SpecialTerrain.None;
		structure = StructureType.None;
		hasSpecial = false;
		hasStructure = false;
		hasArmy = false;
		hasMonster = false;
		occupied = false;
		onScreen = false;
		revealed = false;
		createTile();
	}

	//public GameTile(Vector2 position){
	public GameTile(Vector3 position){
		this.position = position;
		movementVal = 1;
		buildVal = 1;
		foodProduction = 1;
		goldProduction = 1;
		manaProduction = 1;
		maxPopulation = 1;
		terrain = TerrainType.Desert;
		altTerrain = SpecialTerrain.None;
		structure = StructureType.None;
		hasSpecial = false;
		hasStructure = false;
		hasArmy = false;
		hasMonster = false;
		occupied = false;
		onScreen = false;
		revealed = false;
		createTile();
	}

	// Adds the physical representation of the game tile
	public GameObject createTile(){
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = this.position;
		cube.transform.localScale = new Vector3(10,10,1);
		return cube;
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
}
