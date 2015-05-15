using UnityEngine;
using System.Collections;
using System;

public class Goal : MonoBehaviour {

	private int ballCount;
	private int counter;
	private bool cleared;

	public GUIStyle labelStyle;

	// Use this for initialization
	void Start () {
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Ball")
		{
			counter++;

			if(cleared == false && counter == ballCount)
			{
				cleared = true;
				Debug.Log("Cleared!");


				StartCoroutine(Example());
				
			}
		}
	}

	IEnumerator Example()
	{
		print(Time.time);
		yield return new WaitForSeconds(2);
		print(Time.time);
		Application.LoadLevel("title");
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Ball")
		{
			counter--;
		}
	}

	void OnGUI()
	{
		//if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
		//    print("You clicked the button!");

		if (cleared == true)
		{
			int sw = Screen.width;
			int sh = Screen.height;

			GUI.Label(new Rect(sw / 6, sh / 3, sw * 2 / 3, sh / 3), "cleared!", labelStyle);
		}
	}

}
