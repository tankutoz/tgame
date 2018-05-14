using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States{cell, mirror, sheet_0, lock_0, cell_mirror, sheet_1, lock_1, freedom};
	private States myState;
	private int mrr;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell){
			state_cell();
		}
		else if (myState == States.sheet_0){
			state_sheets_0();
		}
		else if (myState == States.lock_0){
			state_lock_0();
		}
		else if (myState == States.mirror){
			state_mirror();
		}
		else if (myState == States.cell_mirror){
			state_cell_mirror();
		}
		else if (myState == States.sheet_1){
			state_sheet_1();
		}
		else if (myState == States.lock_1){
			state_lock_1();
		}
		else if (myState == States.freedom){
			state_freedom();
		}
	}
	
	#region states
	
	void state_cell(){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, ad the door" +
					" is locked from the outside.\n\n" +
					"Press S to view sheets, M to view mirror and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheet_0;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
		else if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}
	}
	
	void state_sheets_0(){
		text.text = "You cant belive you sleep in these things "+
					"You wish you didnt steal that body pillow\n\n"+
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_lock_0(){
		text.text = "Its a lock key uuu if anything you learned from all the episodes you watched "+
					"its that cops eat donuts and there will be some resedue on the keys which are pressed "+
					"but you cant see the keys tough lock (pun intended)\n\n"+
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_mirror(){
		text.text = "You went to check yourself in the mirror since you are afraid "+
					"to wreck yourself. You realise it is broken and there is a piece fallen to "+
					"the ground\n\n"+
					"Press T to Take dem piece and R to Return your filthy cage";
					
		if (Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_cell_mirror(){
		text.text = "Cool so now you have a piece yet here you are still in your filthy cell\n\n"+
					"Press S to view sheets and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheet_1;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}
	
	void state_sheet_1(){
		text.text = "Still disgusting\n\n"+
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_1(){
		text.text = "Sooo good news now you can see the buttons and dem resedues\n\n"+
					"Press U to Unlock cell or R to Return to your filthy cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.U)){
			myState = States.freedom;
		}
	}
	
	void state_freedom(){
		text.text = "FREEEEEDOOOOOOOOOOOOOOOM\n\n"+
					"press P to Play Again";
		if (Input.GetKeyDown(KeyCode.P)){
			myState = States.cell;
		}
	}
	
	#endregion
}





























