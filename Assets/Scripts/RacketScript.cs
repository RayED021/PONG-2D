using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RacketScript : MonoBehaviour
{
    public KeyCode upRacket;
    public KeyCode downRacket;

    public GameObject L;
    public GameObject R;
    //public float score;
    //public TMP_Text scoret;
    public AudioSource hit;

    //public GameObject racket;

    public Rigidbody2D rb;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //racket = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upRacket))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y + speed * Time.deltaTime);
        }
        else if (Input.GetKey(downRacket))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y + -speed * Time.deltaTime);
        }

        if (GameOver.instance.gameIsOver)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            if (gameObject.CompareTag("L"))
            {
                gameObject.transform.position = new Vector3(-8, 0, 0);
                L.transform.position = new Vector3(-8.8f, 0, 0);
            }
            if (gameObject.CompareTag("R"))
            {
                gameObject.transform.position = new Vector3(8, 0, 0);
                R.transform.position = new Vector3(8.8f, 0, 0);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hit.Play();
            if(gameObject.transform.localScale.y > 0.4f)
                gameObject.transform.localScale -= new Vector3(0, 0.1f, 0);
            if (gameObject.CompareTag("L") && gameObject.transform.position.x < -6)
            {
                gameObject.transform.position += new Vector3(0.1f, 0, 0);
                L.transform.position += new Vector3(0.1f, 0, 0);
            }
            if (gameObject.CompareTag("R") && gameObject.transform.position.x  > 6)
            {
                gameObject.transform.position -= new Vector3(0.1f, 0, 0);
                R.transform.position -= new Vector3(0.1f, 0, 0);
            }
        }
    }


}
