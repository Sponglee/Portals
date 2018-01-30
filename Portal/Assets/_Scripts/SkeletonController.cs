using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonController : MonoBehaviour {
    
	public Rigidbody rb;
	public Transform model;
    public float speed=1f;
    public float gravity = 1f;
  
    // Use this for initialization
    void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0f, -gravity, 0f);
        rb.velocity = new Vector3(-speed, 0f, 0f);


    }
}