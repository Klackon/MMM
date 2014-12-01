using UnityEngine;
using System.Collections;

/*
 * This class contains most features of game including
 * 'fog of war'
 */

public class GameFeatures : MonoBehaviour {

	public Rect toolbar;
	public Rect playerInfoPanel;
	public Texture bgImage;
	public Texture plBgImage;
	// Use this for initialization
	void Start () {
		toolbar = new Rect(601, 0, 300, 500);
		playerInfoPanel = new Rect(601, 300, 300, 200);
		bgImage = (Texture) Resources.Load("Image/unitDetails", typeof(Texture));
		plBgImage = (Texture)Resources.Load("Image/mirror", typeof(Texture));
		print ("this is a game feature tool bar");
	}
	
	// Update is called once per frame
	void Update () {
		GUI.DrawTexture(toolbar, bgImage, ScaleMode.StretchToFill, true, 10.0F );
		GUI.DrawTexture(playerInfoPanel, plBgImage, ScaleMode.StretchToFill, true, 5.0F);
	}


	void ONGUI(){


		
	}

	public void createFog(){

		print ("hello");
	}


	/*
	 * the method creats a tool bar next to the
	 * main game board, proving the basic game features
	 * for play, and showing the game status
	 * */
	public GameObject createToolbar(){

		print ("hello, this is toolBar method");
		return null;
	}

}
