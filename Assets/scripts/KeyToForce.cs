using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToForce : MonoBehaviour {

	public KeyCode Key;
	public bool Relative;
	public Vector3 DefaultForce;
	public Vector3 PressedForce;

	ConstantForce force;
	void Start () {
		force = GetComponent<ConstantForce>();
	}

	void Update () {
		if (Input.GetKey(Key)){
			UpdateForce(PressedForce);
			//Debug.Log(Key.ToString() + " pressed");
		}
		else {
			UpdateForce(DefaultForce);
		}
	}

	void UpdateForce(Vector3 updatedForce) 
	{
		if (Relative) {
			force.relativeForce = updatedForce;
		}
		else {
			force.force = updatedForce;
		}
	}
}
