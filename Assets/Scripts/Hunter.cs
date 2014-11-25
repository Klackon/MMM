
public class Hunter : UnitsClass{

	private int x;
	private int y;
	private int health;
	// resources to gather
	private int gold;
	private int mana; // can we gather mana
	private int food;
	// should hunter has its own constructor?
	
	public Hunter(int x, int y, int health): base(x, y, health){
		gold = 0;
		mana = 0;
		food = 0;
	}
	
	

	// additional methods for hunters
	public void gatherFood(int amountOfFood){
		food = food + amountOfFood;
	}

	public void gatherGold(int amountOfGold){
		gold = gold + amountOfGold;
	}

	public int turnInFood(){
		int tempFood = food;
		food = 0;
		return tempFood;
	}

	public int turnInGold(){
		int tempGold = gold;
		gold = 0;
		return tempGold;
	}


}