using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Transform g;
    public Vector2 direction;
    //public float score;
    //public TMP_Text scoret;
    //public AudioSource hit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);

    }

    void GoBall()
    {
        g = GetComponent<Transform>();
        

        float rand = Random.Range(0, 8);

        if (rand < 2)
            direction = new Vector2(1, -1);
        else if (rand > 1 && rand <4)
            direction = new Vector2(1, 1);
        else if (rand > 3 && rand < 6)
            direction = new Vector2(-1, -1);
        else
            direction = new Vector2(-1, 1);
        rb.AddForce(direction * speed);
    }

    // Update is called once per frame
    void Update()
    {
        //scoret.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            //score += 1;
            //hit.Play();
        }

        if (collision.CompareTag("Bound"))
        {

        }
    }

    public void RestartGame()
    {
        if (GameOver.instance.gameIsOver)
        {
            rb.velocity = Vector2.zero;
            transform.position = Vector2.zero;
        }
        else
        {
            rb.velocity = Vector2.zero;
            transform.position = Vector2.zero;
            Invoke("GoBall", 1);

        }
        
    }
}
