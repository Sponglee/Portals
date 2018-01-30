using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public Transform model;
    public float speed=1f;
    public float gravity = 1f;
    public Text scoreText;
    public Text gameOverText;
 
    private bool gameOver;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0f, -gravity, 0f);
       // rb.velocity = new Vector3(-speed, 0f, 0f);
    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
             rb.velocity = new Vector3(-speed, 0f, 0f);
         else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
             rb.velocity = new Vector3(speed, 0f, 0f);
         else
             rb.velocity = new Vector3(0f, 0f, 0f);
            
    }

   

}