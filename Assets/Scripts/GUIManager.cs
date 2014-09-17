using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public GUIText gameOverText, instructionsText, jumpsText;
	
	// this seems pretty dodgy, although I guess if you know there is just one ... ugh
	private static GUIManager instance;

	void Start () {
		// perhaps should check here to make sure only one?
		instance = this;
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		//gameOverText.enabled = false;
		//instructionsText.enabled = true;
		//jumpsText.enabled = false;
	}

	void Update () {
		/*
		if(Input.GetButtonDown("Jump")){
			GameEventManager.TriggerGameStart();
		}

		if(Input.GetKeyDown (KeyCode.G)){
			Application.LoadLevel(1);
		}
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel(0);
		}
		*/
	}

	/*
	IEnumerator FadeInstructions() {
		for (float f = 5f; f >= 0; f -= 0.05f) {
			Color c = instructionsText.color;
			c.a = f/5f;
			instructionsText.color = c;
			yield return new WaitForSeconds(.01f);
		}
		instructionsText.enabled = false;
	}
	*/
	
	private void GameStart () {
		//gameOverText.enabled = false;
		//instructionsText.enabled = false;
		//StartCoroutine(FadeInstructions());
		//jumpsText.enabled = true;
		//enabled = false;
	}

	private void GameOver () {
		//gameOverText.enabled = true;
		//instructionsText.enabled = true;
		//enabled = true;
	}
	
	public static void SetJumps(int jumps){
		//instance.jumpsText.text = "Jumps: " + jumps.ToString();
	}
}