using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalController : MonoBehaviour {
    public float speed=15f;
    public Collider col;
	// Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
