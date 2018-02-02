using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
    public GameObject gameControllerObject;
    public int maxHealth = 100;
    private int minHealth = 1;
    private GameController gc;
	public Slider healthbar;


    private void Start()
    {
		if (gameControllerObject != null)
		{
			gc = gameControllerObject.GetComponent<GameController>();
	        gc.AddScore(maxHealth);
		}
    }
    public void TakeDamage(int damageAmount)
    {
        if (maxHealth<minHealth)
        {
			
			if (this.gameObject.CompareTag("Tower"))
				{
					Time.timeScale = 0f;
				}
			Destroy(this.gameObject);
            gc.GameOver();
        }
        else
        {
            maxHealth -= damageAmount;
			healthbar.value -= damageAmount;
            gc.AddScore(maxHealth);
            Debug.Log(maxHealth);
        }
    }
}
