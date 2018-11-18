using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Camera movement.
public class CameraConteroller : MonoBehaviour {
	// Reference to Player object.
	public GameObject player;
	//Is calculated on top of the camera position.
	private Vector3 offset;

	
	/*
	 * Transform references the transform of the game object that this scrpt is attached to.
	 */
	void Start () {
		offset = transform.position - player.transform.position;	
	}
	
	// Called before rendering a frame.
	/*
	 * Set the transformposition of the camera to the players transform position + the offset. 
	 * Camera is moved into a new possition align with the Player object.
	 */
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
