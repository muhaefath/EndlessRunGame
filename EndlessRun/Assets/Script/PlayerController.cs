using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float dir;
    public bool Move;
    public bool KenaTembok;
  
    SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(speed * dir * Time.fixedDeltaTime,0,0);
        if (Move && !KenaTembok) {
            if (dir == 1)
            {
                sprite.flipX = false;
            }
            else {
                sprite.flipX = true;
            }
            transform.Translate(speed * dir * Time.fixedDeltaTime, 0, 0);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallplus")
        {
            Debug.Log("masuk plus");
            KenaTembok = true;
        }
        else if (collision.gameObject.name == "wallmin")
        {
            Debug.Log("masuk min");
            KenaTembok = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallplus")
        {
            if (dir == 1 )
            {
                speed = 0;
            }
            else {
                speed = 5;
            }
        }
        else if (collision.gameObject.name == "wallmin")
        {
            Debug.Log("masuk min");
            if (dir == -1)
            {
                speed = 0;
            }
            else
            {
                speed = 5;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "wallplus")
        {
            Debug.Log("masuk plus");
            KenaTembok = false;
        }
        else if (other.gameObject.name == "wallmin")
        {
            Debug.Log("masuk min");
            KenaTembok = false;
        }
    }
}
