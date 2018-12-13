using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float dir;
    public bool Move;
    public bool kenaTembokPlus;
    public bool kenaTembokMin;

    public GameObject Ledakan;

    SpriteRenderer sprite;

    public GameManagerController manager;

    public float waktu;
    bool Mati;
    public HoldButton[] hold;
    // Use this for initialization
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        Ledakan.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        //transform.Translate(speed * dir * Time.fixedDeltaTime,0,0);
        if (Move && !kenaTembokPlus && !kenaTembokMin) {
            if (dir == 1)
            {
                sprite.flipX = false;
            }
            else {
                sprite.flipX = true;
            }
            transform.Translate(speed * dir * Time.fixedDeltaTime, 0, 0);
        }

        if (kenaTembokPlus && Move == true && hold[1].pencet ) {
            kenaTembokPlus = false;
        }
        else if(kenaTembokMin && Move == true && hold[0].pencet) {
            kenaTembokMin = false;
        }


        if (Mati) {
            StartCoroutine(DeathCanvas());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "wallplus")
        {
            kenaTembokPlus = true;
         //   manager.Right.SetActive(false);
        
        }
         if (collision.gameObject.name == "wallmin")
        {
            kenaTembokMin = true;
          //  manager.Left.SetActive(false);
            
        }

        if (collision.gameObject.tag == "obs")
        {
            Ledakan.SetActive(true);
            Mati = true;
            Destroy(collision.gameObject);
          //  Time.timeScale = 0;

        }
        if (collision.gameObject.tag == "Peluru")
        {
            Ledakan.SetActive(true);
            Mati = true;
            Destroy(collision.gameObject);
            //  Time.timeScale = 0;

        }
    }

    IEnumerator DeathCanvas( ) {
        if (waktu > 0)
        {
            waktu -= Time.deltaTime;
            yield return null;
        }
        else {
            manager.CanvasDeath.SetActive(true);
        }
    }

    

   

    private void OnTriggerStay2D(Collider2D collision)
    {
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallplus")
        {
           // kenaTembok = false;
            //manager.Right.SetActive(true);
        }
         if (collision.gameObject.name == "wallmin")
        {
            //kenaTembok = false;
           // manager.Left.SetActive(true);
        }
    }


}
