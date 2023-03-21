using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject panelGame;
    public GameObject panelGO;
    public GameObject ball;

    public bool gameIsOver;

    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameOver instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameIsOver = false;
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
        panelGame.SetActive(true);
        panelGO.SetActive(false);
    }

    void Update()
    {
        if(PlayerScoreL == 30 || PlayerScoreR == 30)
        {
            gameIsOver = true;
            GameOverCall();
        }
    }

    public void GameOverCall()
    {
        
        panelGame.SetActive(false);
        panelGO.SetActive(true);
        Time.timeScale = 0;
    }

    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 10;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();

        }
    }
}
