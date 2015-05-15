using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	public GUIStyle labelStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{
			Application.LoadLevel("main");
		}

		
	}

	void OnGUI()
	{
		int sw = Screen.width;
		int sh = Screen.height;

		GUI.Label(new Rect(sw / 6, sh / 3, sw * 2 / 3, sh / 3), "hit space key", labelStyle);
	}
}
