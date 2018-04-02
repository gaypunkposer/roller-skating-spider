using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	public Transform Target;
	public Vector3 Offset;
	public float FollowTime;
	void Start () {
		
	}
	
	void Update () {
		Vector3 target = Vector3.Lerp(transform.position, Target.position, FollowTime);
		target += Offset;
		transform.position = target;
	}
}
