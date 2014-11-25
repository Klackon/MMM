public abstract class UnitsClass{
	private int x; // columns
	private int y; // rows
	private int health;
	
	public UnitsClass(int x, int y, int health){
		this.x = x;
		this.y = y;
		this.health = health;
	}

	public UnitsClass(){
		// somehow this is needed
		x = 1;
		y = 1;
		health = 500;
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




	public Location getLocation(){
		Location loc = new Location (y, x);
		return loc;
	}

	public void setLocation(Location lctn){
		int[] loc = lctn.getIndex ();
		y = loc [0];
		x = loc [1];
	}

	public Location[] canSee(){
		int ind = 0;
		Location[] array;
		if ((y == 1) & (x == 1)){
			array = new Location[4];
			for (int r = y; r <= y+1; r++){
				for (int c = x; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if((y == 20) && (x == 1)){
			array = new Location[4];
			for (int r = y-1; r <= y; r++){
				for (int c = x; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if((y == 1) && (x == 20)){
			array = new Location[4];
			for (int r = y; r <= y+1; r++){
				for (int c = x-1; c <= x; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if((y == 20) && (x == 20)){
			array = new Location[4];
			for (int r = y-1; r <= y; r++){
				for (int c = x-1; c <= x; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if(y == 1){
			array = new Location[6];
			for (int r = y; r <= y+1; r++){
				for (int c = x-1; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if(x == 1){
			array = new Location[6];
			for (int r = y-1; r <= y+1; r++){
				for (int c = x; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if(y == 20){
			array = new Location[6];
			for (int r = y-1; r <= y; r++){
				for (int c = x-1; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else if(x == 20){
			array = new Location[6];
			for (int r = y-1; r <= y+1; r++){
				for (int c = x-1; c <= x; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		else{
			array = new Location[9];
			for (int r = y-1; r <= y+1; r++){
				for (int c = x-1; c <= x+1; c++){
					Location loc = new Location(r, c);
					array[ind] = loc;
					ind++;
				}
			}
		}
		return array;

	}



	public int getHealth(){
		return health;
	}

	public void die(){
		health = 0;
	}

	public bool attack(Monster monster){
		// true means the attack was successful, the monster die.
		return true;
	}


}
