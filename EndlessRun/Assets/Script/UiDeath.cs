using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiDeath : MonoBehaviour {

    public Text Score;
  //  public Button Restart;
    GameManagerController manager;
	// Use this for initialization
	void Start () {
        manager = FindObjectOfType<GameManagerController>();
        Score.text = "" + Mathf.RoundToInt( manager.Score);
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame(string NamaScene) {
        Time.timeScale = 1;
        SceneManager.LoadScene(NamaScene);
    }
}
