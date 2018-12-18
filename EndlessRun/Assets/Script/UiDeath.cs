using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiDeath : MonoBehaviour {

    public Text Score;
    public Text HighScore;
  //  public Button Restart;
    GameManagerController manager;

    private void Awake()
    {
        manager = FindObjectOfType<GameManagerController>();
    }
    // Use this for initialization
    void Start () {
        if (manager.AmbilNilaiHighScore() < Mathf.RoundToInt(manager.Score))
        {
            HighScore.enabled = true;
            manager.SavePlayers();
        }
        else {
            HighScore.enabled = false;
        }
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
