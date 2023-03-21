using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wall : MonoBehaviour
{
    public GameObject GM;
    //public float score;
    //public TMP_Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoretext.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            string wallName = transform.name;
            GameOver.instance.Score(wallName);
            collision.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);

            //score += 10;
        }
    }

}
