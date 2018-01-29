using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    public Text gameOverText;
    private int score;
    private bool gameOver;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
     

    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

}