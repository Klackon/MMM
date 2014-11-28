using UnityEngine;
using System.Collections;

public class Location{
	int[] index = new int[2]; 
	public GameObject gameCam;
	public int x;
	public int y;
	//public GameBoard board;
	public GameTile tile;

	public Location(int i, int j){
		index = new int[2];
		index[0] = i;
		index[1] = j;
		y = i;
		x = j;
	}

	public int[] getIndex(){
		return index;
	}

	public void setTile(GameTile gt){
		tile = gt;
	}

	public GameTile getTile(){
		return tile;
	}
}
