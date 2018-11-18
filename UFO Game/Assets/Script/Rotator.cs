using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Defines rotator behavior.
public class Rotator : MonoBehaviour {

	/*
	 * Rotation around the z axis.
	 */ 
	void Update () {
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
