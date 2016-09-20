using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class GameLogic : MonoBehaviour {

	bool didPlayerwin = false; 
	public Text Line; 
	public Text Line2; 
	public Transform Player; 
	public Transform Treasure; 
	public Transform Ball; 
	public Transform Meat; 
	public Transform Juice; 
	public Transform Note; 


	// Use this for initialization
	void Start () {

		Line.text = "You are a hobo (pan on your head) lost at your local swimming pool.";
		Line2.text = "You need food. You can smell a scent coming directly south..."; 
	
	}
	
	// Update is called once per frame
	void Update () {

		if (didPlayerwin) {
			Line.text = "You got a SOUP CAN!"; 
			Line2.text = "Hopefully you can live another day..."; 

			//SOUP CAN 
		

		} else if ((Player.position - Treasure.position).magnitude < 5f) {
			Line.text = "Press SPACE to get soup can!";
			if (Input.GetKeyDown (KeyCode.Space)) { 
				didPlayerwin = true;
			}

		} else if ((Player.position - Ball.position).magnitude < 5f) { //BALL OBJECT 
			Line.text = "Oh no! It's just a beach ball coated in olive oil.";
			Line2.text = "But your nose senses something straight east..";

		} else if ((Player.position - Meat.position).magnitude < 5f) { //MEAT OBJECT
			Line.text = "It's someone's corndog, but you're a vegeterian."; 
			Line2.text = "You pick up another scent faraway, north of the brown raft...";
				
		} else if ((Player.position - Juice.position).magnitude < 5f) { //TUBE OBJECT
			Line.text = "It's a kid's empty juicebox.";
			Line2.text = "You spy something to the west..."; 
		} else if ((Player.position - Note.position).magnitude < 5f) { //NOTE OBJECT
			Line.text = "A fellow pool hobo has left a note for you!";
			Line2.text = "Head due south, young'un! Past the undersea hobo surveillance sphere!";
		} 

		 
	} //void update
} //class

