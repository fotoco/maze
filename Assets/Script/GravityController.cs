using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {


	private Vector3 accel;


	// Use this for initialization
	void Start () {
		accel = new Vector3(0, 0, -1);
	}
	
	// Update is called once per frame
	void Update () {
		//Physics.gravity = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 60, Vector3.forward) *
		//    Quaternion.AngleAxis(Input.GetAxis("Vertical") * -60, Vector3.right) *
		//    (Vector3.up * -20);




		accel = (accel + Input.acceleration) * 0.5f;
		Physics.gravity = new Vector3(-accel.y, accel.z, accel.x) * 50;

	}
}
