using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recording;

	private bool paused;
	private float fDelta;

	// Use this for initialization
	void Start () {
		PlayerPrefsManager.UnlockLevel (2);
		print (PlayerPrefsManager.IsLevelUnlocked(1));
		print (PlayerPrefsManager.IsLevelUnlocked(2));

		fDelta = Time.fixedDeltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton ("Fire1")) {
			recording = false;
		} else {
			recording = true;
		}

		if (Input.GetKeyDown(KeyCode.P) && !paused){
			PauseGame ();
			paused = true;
		}else if (Input.GetKeyDown(KeyCode.P) && paused){
			ResumeGame ();
			paused = false;
		}

	}

	void PauseGame(){

		Time.timeScale = 0f;
		Time.fixedDeltaTime = 0f;
	}

	void ResumeGame(){
		
		Time.timeScale = 1f;
		Time.fixedDeltaTime = fDelta;
	
	}
}
