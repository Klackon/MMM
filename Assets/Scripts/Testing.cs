using UnityEngine;
using System.Collections;

public class Testing{

	public int Main(string[] args){

		Hunter hunter = new Hunter (1, 1, 500);
		Debug.Log (hunter.getHealth ());
		hunter.die ();
		return 0;
	}



}
