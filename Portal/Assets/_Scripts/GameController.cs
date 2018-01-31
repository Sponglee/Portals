using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
    public GameObject enemy;
    public Transform[] spawnPositions;
    public Vector3 spawnValues;
    public int enemyCount;
    public float spawnWait;
    public float spawnWaitEnemy;
    public float startWait;
    public float waveWait;
    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

   
    private int score;
    private bool gameOver;
    private bool restart;
    // Use this for initialization
    void Start () {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
        
    }


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
            for (int i = 0; i <= enemyCount; i++)
            {
                int rng = Random.Range(0, 3);
                Vector3 spawnPosition = spawnPositions[rng].position;
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(enemy, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWaitEnemy);
            }
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
            yield return new WaitForSeconds(waveWait);


        }
    }


    void Update () {

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                string sceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score = newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Tower health: " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

}