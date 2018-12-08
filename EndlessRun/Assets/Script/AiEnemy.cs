using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiEnemy : MonoBehaviour {

    public float TimeDelay;
    public GameObject Bullet;

    public int Direction;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(ShotBullet());
        transform.Translate(speed * Direction * Time.fixedDeltaTime,0,0);
	}

    IEnumerator ShotBullet() {
        if (TimeDelay > 0)
        {
            TimeDelay -= Time.deltaTime;
            yield return null;
        }
        else {
            Instantiate(Bullet,transform.position,Bullet.transform.rotation);
            TimeDelay = 1.5f;
         
        }
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallplus")
        {
            Debug.Log("masuk plus");
            Direction = -1;
        }
        else if (collision.gameObject.name == "wallmin")
        {
            Debug.Log("masuk min");
            Direction = 1;
        }
    }
}
