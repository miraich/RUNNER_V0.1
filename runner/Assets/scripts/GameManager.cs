using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coins;
    public static GameManager inst;

    public Text CoinsText;

    public void IncrementScore()
    {
        coins++;
        CoinsText.text = "Coins: " + coins;
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
