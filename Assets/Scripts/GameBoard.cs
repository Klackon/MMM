using UnityEngine;
using System.Collections;

public class GameBoard : MonoBehaviour {
	public GameTile[,] board;
	//public int[] index;
	public Location index;
	public int boardSize = 20;
	public UnitsClass[] units;
	public Monster[] monsters;
	public Rect rect;
	Texture hunt;
	Texture scout;
	public Hunter hunter;

	// Use this for initialization
	void Start () {
		float x = 5;
		float y = -5;
		float z = -10;
		//index = new int[2];
		index = new Location(0, 0);
		GameObject gameCam = GameObject.FindGameObjectWithTag("MainCamera");
		GameManager manager;
		manager = gameCam.GetComponent<GameManager>();

		//index[0] = 0;
		//index[1] = 0;
		board = new GameTile[boardSize, boardSize];
		
		for(int i=0; i<boardSize; i++){
			for(int j=0; j<boardSize; j++){
				//Vector2 pos = new Vector2(x, y);
				Vector3 pos = new Vector3(x, y, z);
				board[i, j] = new GameTile(pos);
				board[i, j].setBoard(board);
				board[i, j].setLocation(i, j);
				board[i, j].index.setTile(board[i, j]);
				x+=10;
				if(j==boardSize-1){
					x = 5;
				}
			}
			y-=10;
		}
		manager.setBoard(board);
		print (board[2,0].index.getTile().getPosition().x);
		print (board[2,0].index.getTile().getPosition().y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		hunt = (Texture)Resources.Load ("unit/hunter/1", typeof(Texture));
		scout = (Texture)Resources.Load ("unit/scout/1", typeof(Texture));
		var guiPosition = Camera.main.WorldToScreenPoint(transform.position); 
		guiPosition.y = Screen.height - guiPosition.y; 


		rect = new Rect(board[2,0].index.getTile().getPosition().x*10, board[2,0].index.getTile().getPosition().y*-10, hunt.width, hunt.height); 
		GUI.DrawTexture(rect, hunt);
		//rect = new Rect(guiPosition.x + hunt.width - 200, guiPosition.y + hunt.height - 100, hunt.width, hunt.height); 
		//GUI.DrawTexture(rect, scout);
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

	public Vector3 moveToTile(GameObject go, int[] location){
		Debug.Log("attempting move");
		GameTile tile = board[location[0],location[1]];
		//GameTile tile = board[loc.x,loc.y];

		//go.setLocation(board[location[0],location[1]].getLocation());
		return tile.moveToTile(go);
	}

	/*
	public GameTile getTile(int[] position){
		return board[position[0],position[1]];
	}
	*/

	public GameTile getTile(Location pos){
		return pos.getTile();
	}

	public GameTile[] revealTiles(Location[] canSee){
		GameTile[] tiles = new GameTile[canSee.Length];
		for(int i=0; i<canSee.Length; i++){
			tiles[i] = canSee[i].getTile();
		}
		foreach(GameTile gt in tiles){
			//gt.revealed = true;
			gt.setRevealed(true);
		}
		return tiles;
	}

	public GameTile[,] getBoard(){
		return board;
	}
}
