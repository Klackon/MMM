public class Monster{

	private int x;
	private int y;

	public Monster(int initialX, int initialY){
		x = initialX;
		y = initialY;
	}

	// assume my assumption about the board is correct in terms of direction 
	public void move(){
		// think about this
		// board is 20x20
		if (x == 20) {
			// can't move anymore to the west
		}

		if (y == 20) {
			// can't move anymore to the south
		}

		if (x == 1) {
			// can't move anymore to the east
		
		}

		if (y == 1) {
			// can't move anymore to the north
		}
	}

	public bool attack(UnitsClass victim){
		// maybe the victim will die, maybe the monster itself will die
		// true means the attack was successful, the victim die.
		return true;
	}


	public void die(){
		// failed to attack the victim and die like a loser
	}

	public int getX(){
		return x;
	}

	public int getY(){
		return y;
	}
}
