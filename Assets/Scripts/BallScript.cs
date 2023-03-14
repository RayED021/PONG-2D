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
    public float score;
    public TMP_Text scoret;

    // Start is called before the first frame update
    void Start()
    {
        
        g = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

        float rand = Random.Range(0, 8);

        if(rand <4)
            direction = new Vector2(1, -1);
        else if(rand > 3)
            direction = new Vector2(1, 1);
        rb.AddForce(direction * speed);
            
    }

    // Update is called once per frame
    void Update()
    {
        scoret.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            score += 100;
        }
    }
}
