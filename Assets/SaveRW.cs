using UnityEngine;
using System.Collections;

public class SaveRW : MonoBehaviour {
	public static void Save() {
		PlayerPrefs.Save ();
	}
}
