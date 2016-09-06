using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour {
	public void OnClick() {
		if (PlayerPrefs.GetInt("Character") <= 0) {
			SceneManager.LoadScene ("CharacterSelect");
		}
		if(PlayerPrefs.GetInt("Character") > 0) {
			SceneManager.LoadScene(PlayerPrefs.GetString("SceneName"));
		}
	}
}
