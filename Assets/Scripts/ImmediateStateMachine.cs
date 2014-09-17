using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*   State Template
 * 
	// IDLE STATE
	bool enterIDLE ()
	{
		return true;
	}
	
	bool updateIDLE ()
	{
		float x = Input.GetAxisRaw("Horizontal");
		if(x != 0)
			stateMachine.ChangeState(enterWALK, updateWALK, exitWALK);
		 
		return false;
	}
	
	bool exitIDLE ()
	{
		return true;
	}

*/

// Defines the required parameters and return value type for a StateMachine state.
public delegate void ImmediateStateDelegate ();
 
// To use, create an instance of StateMachine inside of a MonoBehaviour, load it up with
// references to state methods with ChangeState(), then call its Execute() method during the
// MonoBehaviour's Update cycle. An example MonoBehaviour is included at the bottom of this file.
public class ImmediateStateMachine
{ 	
	// These states will be cached when calling ChangeState().
	// The Execute() method will execute onUpdate() of the current state on each update,
	// running whatever method is stored there.
	ImmediateStateDelegate enter;
	ImmediateStateDelegate update;
	ImmediateStateDelegate exit;
 
	// Change state from the previous state, if any, and begin working in the new state.
	// The previous state's onExit() and the new state's onEnter() will both be called.
	public void ChangeState (ImmediateStateDelegate enter, ImmediateStateDelegate update, ImmediateStateDelegate exit)
	{ 
		// If a state is currently running, it should be allowed to gracefully exit
		// before the next state takes over
		if (this.exit != null)
			this.exit();
 
		// Cache the given state values
		this.enter = enter;
		this.update = update;
		this.exit = exit;
 
		// If a state isn't currently running, we can immediately switch to our entering
		// state using the state delegates we cached a few lines above
		if (this.enter != null)
			this.enter();
	}
 
	// Call this during
	public void Execute ()
	{
		if (this.update != null)
			this.update(); 
	}
	
	public bool IsUsingThisUpdateDelegate(ImmediateStateDelegate update)
	{
		return (this.update == update);
	}
}
 
 