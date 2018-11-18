using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Defines the player and the game state.
 */
public class PlayerController : MonoBehaviour {
	// Spped of the Player (UFO).
	public float speed;
	// Amount of collected items.
	public Text countText;
	//Game over text.
	public Text winText;
	//physical representation of the object.
	private Rigidbody2D rb2d;
	// Counts the collected items.
	private int count;


	/*
	 * Initializes the player.
	 */
	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		winText.text = "";
		SetCountText();
	}

	//Called just before performing any physics calculations.
	/*
	 * Grabs the Input from the player through the keyboard going horizontal and vertical.
	 */
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * speed);
	}

	/*
	 * Tests if the tag is in the same as the string value Pickup,
	 * if so the other game obcet is taken and called SetActive to 
	 * false to deactivate the gameobject. 
	 * 
	 * @param other is a different game object.
	 */ 
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	/*
	 * Counts up when collection an pickup/items.
	 */
	void SetCountText() {
		countText.text = "Count: " + count.ToString();
		//Returns you win when player collected all Pickups.
		if (count >= 12) {
			winText.text = "You win!";
		}
	}
}
