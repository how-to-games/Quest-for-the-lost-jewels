using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetCharacter(int character) {
		GetComponents<SpriteRenderer> ().enabled = false;
		GameObject.Find ("Character" + character).GetComponents<SpriteRenderer> ().enabled = true;
	}
}
