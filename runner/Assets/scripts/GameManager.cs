using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coins;
    public int score;
    public static GameManager inst;

    public Text CoinsText;
    public Text ScoreText;

    public void IncrementCoins()
    {
        coins++;
        CoinsText.text = "Coins: " + coins;
    }

    public void IncrementScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        inst = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
