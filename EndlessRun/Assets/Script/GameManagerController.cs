using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerController : MonoBehaviour {

    public Transform[] LocationObstacle;
    public GameObject[] ObstacleType;
    public float DelayTime;

    public float DelayBubble;
    public GameObject bubble;

    public float Score;
    public Text ScoreText;

    public GameObject Left;
    public GameObject Right;

    public GameObject CanvasDeath;

	// Use this for initialization
	void Start () {
        CanvasDeath.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(SpawnObsatcle());
        StartCoroutine(SpawnBubble());
        Score += Time.deltaTime;
        ScoreText.text = "" + Mathf.RoundToInt(Score) ;
    }

    IEnumerator SpawnObsatcle() {
        if (DelayTime > 0)
        {
            DelayTime -= Time.deltaTime;
            yield return null;
        }
        else {
            int random = Random.Range(0, LocationObstacle.Length);
            int obs = Random.Range(0, ObstacleType.Length);

            Instantiate(ObstacleType[obs], LocationObstacle[random].position, ObstacleType[obs].transform.rotation);

            DelayTime = 4f;
        }
    }

    IEnumerator SpawnBubble() {
        if (DelayBubble > 0)
        {
            DelayBubble -= Time.deltaTime;
            yield return null;
        }
        else
        {
            int random = Random.Range(0, LocationObstacle.Length);
            Instantiate(bubble, LocationObstacle[random].position, LocationObstacle[random].rotation);

            DelayBubble = 2f;
        }
    }

   
}
