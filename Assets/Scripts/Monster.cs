public class Monster{

	private int x;
	private int y;
	private int health;

	public Monster(int initialX, int initialY, int health){
		x = initialX;
		y = initialY;
		this.health = health;
	}

	// assume my assumption about the board is correct in terms of direction 

	public bool attack(UnitsClass victim){
		// maybe the victim will die, maybe the monster itself will die
		// true means the attack was successful, the victim die.
		return true;
	}


	public void die(){
		// failed to attack the victim and die like a loser
		health = 0;
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
}
