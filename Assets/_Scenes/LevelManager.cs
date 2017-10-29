using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
        Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest(){
        Debug.Log("The user wants to quit!!!");
        Application.Quit();
    }
}