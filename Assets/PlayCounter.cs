using UnityEngine;
using System.Collections;

public class PlayCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("plays", PlayerPrefs.GetInt ("plays") + 1);
		PlayerPrefs.Save ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
