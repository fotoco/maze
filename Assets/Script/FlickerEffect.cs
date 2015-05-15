using UnityEngine;
using System.Collections;
using System;

public class FlickerEffect : MonoBehaviour {

	private Color originalColor;
	private Renderer rend;
	
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		originalColor = rend.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		float level = Mathf.Abs(Mathf.Sin(Time.time * 20));
		rend.material.color = originalColor * level;
	}
}
