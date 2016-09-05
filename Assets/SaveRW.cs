using UnityEngine;
using System.Collections;

public class SaveRW : MonoBehaviour {
	public static void Save() {
		print ("Saving");
		PlayerPrefs.Save ();
		print ("Saved!");
	}
}
