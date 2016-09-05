using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelProgression : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GoToLevel(int level) {
		PlayerPrefs.SetString("SceneName", "Level" + level);
		SaveRW.Save ();
		SceneManager.LoadScene (PlayerPrefs.GetString ("SceneName"));
	}
}
