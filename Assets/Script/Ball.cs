using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Rigidbody.WakeUp();
		//rigidbody.WakeUp();

		var aa = gameObject.GetComponent<Rigidbody>();
		aa.WakeUp();
	}
}
