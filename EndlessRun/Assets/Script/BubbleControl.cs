using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleControl : MonoBehaviour {

    public float speed;
    public int Identity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,speed*Time.deltaTime,0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Top")
        {
            Debug.Log("masuk top");
            Destroy(gameObject);
        }

    }
}
