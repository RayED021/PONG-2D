using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject ball;
    private Vector2 ballPos;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ballPos = ball.GetComponent<Rigidbody2D>().position;
        if(ballPos.y > 3.6 || ballPos.y < -3.6)
        {

        }
        else
            rb.position = new Vector2(rb.position.x, ballPos.y);
    }

}
