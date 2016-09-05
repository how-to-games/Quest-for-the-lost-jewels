using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	int characterselected = PlayerPrefs.GetInt("character");
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("character", characterselected);
	}
}
