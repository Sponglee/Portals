using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPositioner : MonoBehaviour {
    public Transform[] orbSpots;
    public Transform[] beamSpots;
    public GameObject Beam;
    public GameObject orb;
    private Transform randomSpawn;
	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            NewOrb(); 
           
           
        }

	}

    public void NewOrb()
    {
        int rng = Random.Range(0, 3);

        randomSpawn = beamSpots[rng];
        transform.LookAt(randomSpawn);
        Instantiate(orb, orbSpots[rng]);
        Instantiate(Beam, transform);
    
      
      
    }
}
