using UnityEngine;

public class Scout : UnitsClass{

	private int x;
	private int y;
	private int health;

	public Scout(int x, int y, int health): base(x, y, health){}

	public void buildOutpost()
	{
		Outpost newPost = new Outpost ("New Outpost", "Klackon", x, y);
		GameObject outpost = GameObject.CreatePrimitive(PrimitiveType.Cube);
		outpost.transform.localScale = new Vector3 (10, 10, 1);
	}

	public void moveScout(int x, int y)
	{
		this.x = x;
		this.y = y;
	}


}
