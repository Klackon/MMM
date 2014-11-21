public abstract class UnitsClass{
	private int x;
	private int y;
	private int health;


	public UnitsClass(int x, int y, int health){
		this.x = x;
		this.y = y;
		this.health = health;
	}

	public UnitsClass(){
		// somehow this is needed
	}
	
	public void setX(int x){
		this.x = x;
	}
	public void setY(int y){
		this.y = y;
	}
	public int getX(){
		return x;
	}
	public int getY(){
		return y;
	}
	public int getHealth(){
		return health;
	}

	public void die(){
		health = 0;
	}

	public bool attack(Monster monster){
		// true means the attack was successful, the victim die.
		return true;
	}

	public void setExplored(){
		// set the current spot on the map as explored with the current values of x and y
		// need to call some method that owned by the board
		// something like board.setValue (x, y);
	}
}
