using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RacketScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y + speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y + -speed * Time.deltaTime);
        }
    }
}
