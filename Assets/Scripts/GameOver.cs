using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject panelGame;
    public GameObject panelGO;
    public float health;
    //public TMP_Text healtht;
    //public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //health = 3;
        panelGame.SetActive(true);
        panelGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            panelGame.SetActive(false);
            panelGO.SetActive(true);
        }
    }
}
