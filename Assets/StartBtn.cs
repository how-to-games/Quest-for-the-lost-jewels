using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour {
	public void OnClick() {
		if (PlayerPrefs.GetInt ("plays") <= 1) {
			SceneManager.LoadScene ("CharacterSelect");
		}
		if(PlayerPrefs.GetInt("plays") > 1) {
			SceneManager.LoadScene(PlayerPrefs.GetString("SceneName"));
		}
	}
}
