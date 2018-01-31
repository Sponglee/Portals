using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public GameObject gameControllerObject;
    public int maxHealth = 100;
    private int minHealth = 1;
    private GameController gc;
    private void Start()
    {
        gc = gameControllerObject.GetComponent<GameController>();
        gc.AddScore(maxHealth);
    }
    public void TakeDamage(int damageAmount)
    {
        if (maxHealth<minHealth)
        {
            Destroy(this.gameObject);
            gc.GameOver();
        }
        else
        {
            maxHealth -= damageAmount;
            gc.AddScore(maxHealth);
            Debug.Log(maxHealth);
        }
    }
}
