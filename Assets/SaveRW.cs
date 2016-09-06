using UnityEngine;
using System.Collections;

public class SaveRW : MonoBehaviour {
	public static void Save() {
		print ("Saving");
		PlayerPrefs.Save ();
		print ("Saved!");
	}
	public static void Reset() {
		print("Resetting");
		PlayerPrefs.DeleteAll ();
		print ("Reset all");
	}
	public void ResetBtn() {
		Reset ();
	}
	public void SaveBtn() {
		Save ();
	}
}
